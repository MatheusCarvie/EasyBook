using DotNetEnv;
using EasyBook.Api.Middlewares;
using EasyBook.Application.Services;
using EasyBook.CrossCutting.Mappings;
using EasyBook.Infrastructure;
using EasyBook.Infrastructure.Repositorys;
using FluentValidation;
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

// Injeta as validações
builder.Services.AddValidatorsFromAssemblyContaining<Program>();

// Define os Mappers
builder.Services.AddAutoMapper(typeof(EntityToDtoProfile), typeof(ModelToEntityProfile));

// Injeção de dependencias das Service e dos Repositorys
builder.Services.AddScoped<UserService>();
builder.Services.AddScoped<UserRepository>();

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
