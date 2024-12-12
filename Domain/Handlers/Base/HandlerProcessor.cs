using Domain.Handlers.Exceptions;
using Microsoft.Extensions.DependencyInjection;

namespace Domain.Handlers.Base
{
    public class HandlerProcessor : IHandlerProcessor
    {
        private readonly IServiceProvider _serviceProvider;
        public HandlerProcessor(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public Task<TResponse> Process<TRequest, TResponse>(TRequest request)
        {
            var handler = _serviceProvider.GetService<IBaseHandler<TRequest, TResponse>>();

            if (handler == null)
                throw new UnknownHandlerException($"Handler for \"{request.GetType().Name}\" not found.");

            return handler.Handle(request);
        }
    }
}
