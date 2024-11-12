using MinimalAPI.Domain.DTO;
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapPost("/login", (LoginDTO loginDTO) =>
{
  if (loginDTO.Email == "admin@teste.com" && loginDTO.Password == "123456")
  {
    return Results.Ok("Hello admin!");
  }
  else
  {
    return Results.Unauthorized();
  }
});


app.Run();

