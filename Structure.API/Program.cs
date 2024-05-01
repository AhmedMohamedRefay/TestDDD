using Microsoft.EntityFrameworkCore;
using Structure.Domain.Interfaces.Repository;
using Structure.Infrastructure.DataBase;
using Structure.Infrastructure.Repository.CompanyRepository;
using Structure.Infrastructure.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<StructureContext>(options =>
{
    options.UseNpgsql(builder.Configuration.GetConnectionString("HR"));
});
builder.Services.AddScoped<ICompanyRepository,CompanyRepository>();
builder.Services.AddScoped<ICompanyservice, Companyservice>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
