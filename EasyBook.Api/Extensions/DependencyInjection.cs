using EasyBook.Application.Services;
using EasyBook.CrossCutting.Mappings;
using EasyBook.Infrastructure.Repositorys;
using FluentValidation;

namespace EasyBook.Api.Extensions
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            // Injeta os Mappers
            #region Mappers
            services.AddAutoMapper(typeof(EntityToDtoProfile), typeof(ModelToEntityProfile));
            #endregion

            // Injeta as validações
            #region Validations
            services.AddValidatorsFromAssemblyContaining<Program>();
            #endregion

            // Injeta dependencias das services
            #region Services
            services.AddScoped<UserService>();
            services.AddScoped<BookService>();
            services.AddScoped<BookstoreService>();
            services.AddScoped<LoanService>();
            services.AddScoped<ReturnService>();
            #endregion

            // Injeta dependencias dos repositorys
            #region Repositorys
            services.AddScoped<UserRepository>();
            services.AddScoped<BookRepository>();
            services.AddScoped<BookstoreRepository>();
            services.AddScoped<LoanRepository>();
            services.AddScoped<ReturnRepository>();
            #endregion

            return services;
        }
    }
}
