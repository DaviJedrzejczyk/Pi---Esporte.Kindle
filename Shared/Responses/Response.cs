namespace Shared.Responses
{
    public class Response
    {
        public string Message { get; set; }
        public bool HasSuccess { get; set; }
        public Exception Exception { get; set; }

        public Response(string message, bool hasSuccess, Exception exception)
        {
            Message = message;
            HasSuccess = hasSuccess;
            Exception = exception;
        }
        public Response()
        {

        }
    }
}