using Membership.Application.Features.Customers.Commands.Create;
using Microsoft.AspNetCore.Mvc;

namespace Membership.WepAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : BaseController
    {
        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateCustomerCommand createCustomerCommand)
        {
            CreateCustomerResponse response = await Mediator!.Send(createCustomerCommand);
            return Ok(response);
        }
    }
}
