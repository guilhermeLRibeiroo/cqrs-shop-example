using Domain.Commands.Requests;
using Domain.Commands.Responses;
using Domain.Handlers.Base;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomerController : ControllerBase
    {
        [HttpPost]
        public async Task<CreateCustomerResponse> Create(
            [FromServices] IHandlerProcessor handler,
            [FromBody] CreateCustomerRequest command
            )
        {
            return await handler.Process<CreateCustomerRequest, CreateCustomerResponse>(command);
        }
    }
}
