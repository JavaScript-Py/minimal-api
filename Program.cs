using MinimalAPI.Domain.DTO;
using MinimalAPI.Infrastructure.Db;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using MinimalAPI.Infrastructure.Interfaces;
using MinimalAPI.Domain.Services;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
  options.AddPolicy("AllowAllOrigins",
      builder => builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
});

builder.Services.AddScoped<IAdministratorServices, AdministratorServices>();

builder.Services.AddDbContext<MinimalAPI.Infrastructure.Db.MinimalApiDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

app.UseCors("AllowAllOrigins");

app.MapGet("/", () => "Hello World!");

app.MapPost("/login", ([FromBody] LoginDTO loginDTO, IAdministratorServices administratorServices) =>
{

  var r = administratorServices.Login(loginDTO) != null ? Results.Ok("Hello admin!") : Results.Unauthorized();

  return r;

});


app.Run();

