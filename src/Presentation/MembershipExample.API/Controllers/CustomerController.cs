using Membership.Application.Features.Customers.Commands.Create;
using Membership.Application.Features.Customers.Queries.GetById;
using Microsoft.AspNetCore.Mvc;
using FluentValidation.Results;

namespace MembershipExample.API.Controllers
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
        
        [HttpGet]
        public async Task<IActionResult> GetByUserId([FromQuery] GetByUserIdCustomerQuery request)
        {
            var response = await Mediator!.Send(request);
            return Ok(response);
        }
    }
}
