namespace Shared
{
    public class Response
    {
        public bool HasSuccess { get; set; }
        public string Message { get; set; }
        public Exception Exception { get; set; }
    }
}