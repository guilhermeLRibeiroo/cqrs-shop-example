using Domain.Commands.Requests;
using Domain.Commands.Responses;
using Domain.Handlers;
using Domain.Handlers.Base;
using Microsoft.Extensions.DependencyInjection;

namespace Domain.Extensions
{
    public static class DependencyInjectionExtension
    {
        public static void AddHandlers(this IServiceCollection @this)
        {
            @this.AddScoped<IHandlerProcessor, HandlerProcessor>();
            @this.AddHandler<CreateCustomerHandler, CreateCustomerRequest, CreateCustomerResponse>();
        }

        public static void AddHandler<THandler, TRequest, TResponse>(this IServiceCollection @this)
           where THandler : class, IBaseHandler<TRequest, TResponse>
           where TRequest : class
        {
            @this.AddScoped(typeof(IBaseHandler<TRequest, TResponse>), typeof(THandler));
        }
    }
}
