namespace EasyBook.Domain.Exceptions
{
    public class ResultException
    {
        public string Error { get; set; }
        public int StatusCode { get; set; }

        public ResultException(string error, int statusCode)
        {
            Error = error;
            StatusCode = statusCode;
        }
    }
}
