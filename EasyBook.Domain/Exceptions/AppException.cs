using System.Net;
namespace EasyBook.Domain.Exceptions
{
    public class AppException : Exception
    {
        public HttpStatusCode StatusCode { get; private set; }
        public AppException(string message, HttpStatusCode statusCode) : base(message)
        {
            this.StatusCode = statusCode;
        }
    }
}
