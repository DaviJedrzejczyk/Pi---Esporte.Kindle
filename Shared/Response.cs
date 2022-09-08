namespace Shared
{
    public class Response
    {
        public bool HasSuccess { get; set; }
        public string Message { get; set; }
        public Exception Exception { get; set; }
        public Response()
        {

        }

        public Response(bool hasSuccess, string message, Exception exception)
        {
            HasSuccess = hasSuccess;
            Message = message;
            Exception = exception;
        }

        public Response(bool hasSuccess, string message)
        {
            HasSuccess = hasSuccess;
            Message = message;
        }
    }
}