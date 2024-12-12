using Domain.Commands.Requests;
using Domain.Commands.Responses;
using MediatR;

namespace Domain.Handlers
{
    public class CreateCustomerHandler
        : IRequestHandler<CreateCustomerRequest, CreateCustomerResponse>
    {
        public Task<CreateCustomerResponse> Handle(CreateCustomerRequest request, CancellationToken cancellationToken)
        {
            // Do business logic
            // ...

            var result = new CreateCustomerResponse
            {
                Id = Guid.NewGuid(),
                Name = "testing",
                Email = "testing@testing.test",
                Date = DateTime.Now,
            };

            return Task.FromResult(result);
        }
    }
}
