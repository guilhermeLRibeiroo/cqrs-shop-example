namespace Domain.Handlers.Base
{
    public interface IBaseHandler<TRequest, TResponse>
    {
        public Task<TResponse> Handle(TRequest request);
    }
}
