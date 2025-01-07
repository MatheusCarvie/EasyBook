using System.Net;
using System.Text.Json;
using EasyBook.Exceptions;
using EasyBook.Exceptions.Messages;
using FluentValidation;

namespace EasyBook.Server.Middlewares
{
    public class ErrorMiddleware
    {
        private readonly RequestDelegate _next;
        public ErrorMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception exception) 
            {
                await HandleException(exception, context);
            }
        }

        private static Task HandleException(Exception exception, HttpContext context) 
        {
            HttpStatusCode statusCode;
            ResultException result;

            if (exception is AppException appException)
            {
                // Exception padrao do sistema
                statusCode = appException.StatusCode;
                result = new ResultException(appException.Message, (int)appException.StatusCode);
            }
            else if(exception is ValidationException validationException)
            {
                // Exception provinda pela validação da model
                statusCode = HttpStatusCode.BadRequest;
                var errors = validationException.Errors.Select(e => e.ErrorMessage).ToList();
                result = new ResultException(errors, (int)statusCode);
            }
            else
            {
                statusCode = HttpStatusCode.InternalServerError;
                result = new ResultException(ExceptionMessage.INTERNAL_SERVER, (int)statusCode);
            }

            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)statusCode;

            // ToDo: Substituir por um ILogger (Log de produção)
            Console.WriteLine("StackTrace: ", exception.ToString());

            return context.Response.WriteAsync(JsonSerializer.Serialize(result));
        }
    }
}
