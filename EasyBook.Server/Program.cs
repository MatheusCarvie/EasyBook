using DotNetEnv;
using EasyBook.Infrastructure;
using EasyBook.Server.Components;
using EasyBook.Server.Extensions;
using EasyBook.Server.Middlewares;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

// Add Controllers
builder.Services.AddControllers();
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
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}else
{
    // Roda o Swagger em Desenvolvimento
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// Adiciona autorização + controllers
app.UseAuthorization();
app.MapControllers();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
