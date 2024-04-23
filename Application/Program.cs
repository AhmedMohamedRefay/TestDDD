using IdentityServer4.AccessTokenValidation;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Test.Application.Identity;
using Test.Application.MidleWare;
using Test.Domain.Interfaces;
using Test.Domain.UserAggregation;
using Test.Infrastructure.DataBase;
using Test.Infrastructure.Repository;
using Test.Infrastructure.Service;
using StackExchange.Redis;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<EcomerceDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("Ecommerce"));
});
//builder.Services.AddIdentity<ApplicationUser, IdentityRole>().AddEntityFrameworkStores<EcomerceDbContext>();
builder.Services.Configure<MailSettings>(builder.Configuration.GetSection("MailSettings"));
builder.Services.AddTransient<IProductRepository, productRepository>();
builder.Services.AddTransient<IOrderRepository, orderRepository>();
builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();



builder.Services.AddTransient<IMailService, MailService>();
builder.Services.AddScoped<ICacheService, CacheService>();
builder.Services.AddScoped<ISendOPTService, SendOTPService>();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());


//builder.Services.AddAuthentication(IdentityServerAuthenticationDefaults.AuthenticationScheme)
//       .AddIdentityServerAuthentication(options =>
//       {
//           options.ApiName = "myApi";
//           options.Authority = "https://localhost:7029";
//       });
//builder.Services.AddStackExchangeRedisCache(options =>
//{
//    options.Configuration = builder.Configuration["RedisCacheUrl"];
//});
//builder.Services.AddStackExchangeRedisCache(options =>
//{
//    options.Configuration = builder.Configuration.GetValue<string>("CacheSettings:RedisCache");
//});
builder.Services.AddAuthentication("Bearer")
    .AddIdentityServerAuthentication("Bearer", options =>
    {
        options.ApiName = "myApi";
        options.Authority = "https://localhost:7029";
    });
builder.Services.AddIdentityServer()
    .AddInMemoryClients(IdentityConfiguration.Clients)
    .AddInMemoryIdentityResources(IdentityConfiguration.IdentityResources)
    .AddInMemoryApiResources(IdentityConfiguration.ApiResources)
    .AddInMemoryApiScopes(IdentityConfiguration.ApiScopes)
    .AddTestUsers(IdentityConfiguration.TestUsers)
    .AddDeveloperSigningCredential();


var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
 app.UseMiddleware(typeof(ErrorHandlingMiddleware));

// Register any middleware to report exceptions to a third-party service *after* our ErrorHandlingMiddleware
 
app.UseHttpsRedirection();

app.UseIdentityServer();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
