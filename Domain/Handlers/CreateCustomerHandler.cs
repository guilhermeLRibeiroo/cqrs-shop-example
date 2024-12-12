using Domain.Commands.Requests;
using Domain.Commands.Responses;
using Domain.Handlers.Base;
using System.Xml.Linq;

namespace Domain.Handlers
{
    public class CreateCustomerHandler
        : IBaseHandler<CreateCustomerRequest, CreateCustomerResponse>
    {
        public async Task<CreateCustomerResponse> Handle(CreateCustomerRequest request)
        {
            // Do business logic
            // ...
            return new CreateCustomerResponse
            {
                Id = Guid.NewGuid(),
                Name = "testing",
                Email = "testing@testing.test",
                Date = DateTime.Now,
            };
        }
    }
}
