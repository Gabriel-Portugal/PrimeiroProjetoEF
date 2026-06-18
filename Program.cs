using Microsoft.EntityFrameworkCore;
using TarefasAPI.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddControllers();

string? stringDeConexao = builder.Configuration.GetConnectionString("stringConexaoBanco");

if (stringDeConexao is null)
{
    throw new Exception("A string de conexao nao foi definida no appsettings");
}

builder.Services.AddDbContext<TarefasApiContext>(opt => opt.UseNpgsql(stringDeConexao));



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.MapControllers();

app.Run();



