using DataAccess.DependencyInjection.Account.IServices;
using DataAccess.DependencyInjection.Account.Services;
using DataAccess.DependencyInjection.Category.IServices;
using DataAccess.DependencyInjection.Category.Services;
using DataAccess.DependencyInjection.DbHelper;
using DataAccess.DependencyInjection.IServices;
using DataAccess.DependencyInjection.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using NLog;
using System.Text;
using UnitOfWork.DataAccess.DbContext;
using UnitOfWork.DataAccess.Interface;
using UnitOfWork.DataAccess.Repository;
using UnitOfWork.DataAccess.UnitOfWork;
using WebApplicationCoreAPI.Filter;
using WebApplicationCoreAPI.Interface;
using WebApplicationCoreAPI.LoggerService;
using WebApplicationCoreAPI.Repository;
using WebApplicationCoreAPI.UnitOfWork;

var builder = WebApplication.CreateBuilder(args);
ConfigurationManager configuration = builder.Configuration;
LogManager.LoadConfiguration(string.Concat(Directory.GetCurrentDirectory(), "/NLog.config"));

// Add services to the container.
builder.Services.AddDbContext<MyShopUnitOfWorkDbContext>(options =>
               options.UseSqlServer(configuration.GetConnectionString("ConnStr")));

//builder.Services.AddControllers(option => { option.Filters.Add(typeof(CustomeExceptionFilter)); });
builder.Services.AddControllers(option => { option.Filters.Add(typeof(CustomExceptionFilterAttribute)); });
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "ToDo API",
        Description = "An ASP.NET Core Web API for managing ToDo items",
        TermsOfService = new Uri("https://example.com/terms"),
        Contact = new OpenApiContact
        {
            Name = "Example Contact",
            Url = new Uri("https://example.com/contact")
        },
        License = new OpenApiLicense
        {
            Name = "Example License",
            Url = new Uri("https://example.com/license")
        }
    });
});



builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
})

// Adding Jwt Bearer
.AddJwtBearer(options =>
{
    options.SaveToken = true;
    options.RequireHttpsMetadata = false;
    options.TokenValidationParameters = new TokenValidationParameters()
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidAudience = configuration["JWT:ValidAudience"],
        ValidIssuer = configuration["JWT:ValidIssuer"],
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["JWT:Secret"]))
    };
});


//builder.Services.AddTransient<IDbHelper, DBHelper>();
//builder.Services.AddTransient<IProductServices, ProductServices>();
//builder.Services.AddTransient<ICategoryServices, CategoryServices>();
//builder.Services.AddTransient<IAccountServices, AccountServices>();

builder.Services.AddTransient<IUnitOfWork, MyShopUnitOfWork>();
//builder.Services.AddTransient<IProductRepository, ProductRepository>();
//builder.Services.AddTransient<IEmployeerRepository, EmployeerRepository>();
builder.Services.AddTransient<IEmployeerRepositoryGeneric, EmployeerRepositoryGeneric>();
builder.Services.AddSingleton<ILoggerManager, LoggerManager>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();
app.UseAuthentication();
app.MapControllers();

app.Run();
