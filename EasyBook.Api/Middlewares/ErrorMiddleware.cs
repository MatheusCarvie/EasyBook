using EasyBook.Domain.Exceptions;
using System.Net;
using System.Text.Json;

namespace EasyBook.Api.Middlewares
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
                statusCode = appException.StatusCode;
                result = new ResultException(appException.Message, (int)appException.StatusCode);
            }else
            {
                statusCode = HttpStatusCode.InternalServerError;
                result = new ResultException("Internal server error", (int)statusCode);
            }

            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)statusCode;

            return context.Response.WriteAsync(JsonSerializer.Serialize(result));
        }
    }
}
