using Microsoft.EntityFrameworkCore;
using Structure.API.Extensions;
using Structure.Domain.Interfaces.Repository;
using Structure.Infrastructure.DataBase;
using Structure.Infrastructure.Repository.CompanyRepository;
using Structure.Infrastructure.Services;
using Utility.GlobalException;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddMvc().AddNewtonsoftJson
    (options => options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<StructureContext>(options =>
{
    options.UseNpgsql(builder.Configuration.GetConnectionString("HR"));
});
builder.Services.Repositoryconfig(builder.Configuration);
builder.Services.Serviceconfig(builder.Configuration);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseMiddleware(typeof(GlobalErrorHandlingMiddleware));

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
