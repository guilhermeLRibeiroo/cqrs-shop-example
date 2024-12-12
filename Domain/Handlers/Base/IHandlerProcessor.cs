namespace Domain.Handlers.Base
{
    public interface IHandlerProcessor
    {
        Task<TResponse> Process<TRequest, TResponse>(TRequest command);
    }
}
