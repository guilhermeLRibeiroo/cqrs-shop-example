namespace Domain.Handlers.Exceptions
{
    public class UnknownHandlerException : Exception
    {
        public UnknownHandlerException(string message) : base(message) { }
    }
}
