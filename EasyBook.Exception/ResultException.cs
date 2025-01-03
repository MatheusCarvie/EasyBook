namespace EasyBook.Exceptions
{
    public class ResultException
    {
        public object? Error { get; set; }
        public int StatusCode { get; set; }

        public ResultException(object? error, int statusCode)
        {
            Error = error;
            StatusCode = statusCode;
        }
    }
}
