using DotNetEnv;
using EasyBook.Application.Services;
using EasyBook.CrossCutting.Mappings;
using EasyBook.Infrastructure;
using EasyBook.Infrastructure.Repositorys;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Carregar vari�veis do .env
Env.Load();

// Definir a conexao com o banco de dados
builder.Services.AddDbContext<AppDbContext>(options =>
{
    // Obter a connection string do .env
    var connectionString = Environment.GetEnvironmentVariable("DB_DEV_CONNECTION");
    // Define a string de conexao para o banco de dados
    options.UseSqlServer(connectionString);
});

// Define os Mappers
builder.Services.AddAutoMapper(typeof(EntityToDtoProfile), typeof(ModelToEntityProfile));

// Inje��o de dependencias
builder.Services.AddScoped<UserService>();
builder.Services.AddScoped<UserRepository>();

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
