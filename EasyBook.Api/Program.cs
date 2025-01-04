using DotNetEnv;
using EasyBook.Api.Middlewares;
using EasyBook.Infrastructure;
using EasyBook.Api.Extensions;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Carregar variáveis do .env
Env.Load();

// Definir a conexao com o banco de dados
builder.Services.AddDbContext<AppDbContext>(options =>
{
    // Obter a connection string do .env
    var connectionString = Environment.GetEnvironmentVariable("DB_DEV_CONNECTION");
    // Define a string de conexao para o banco de dados
    options.UseSqlServer(connectionString);
});

// Configurações das dependencias
builder.Services.AddApplicationServices();

var app = builder.Build();

// Registra o middleware de tratamento de erros
app.UseMiddleware<ErrorMiddleware>();

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
