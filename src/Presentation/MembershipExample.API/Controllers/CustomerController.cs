using Membership.Application.Features.Customers.Commands.Create;
using Membership.Application.Features.Customers.Queries.GetById;
using Microsoft.AspNetCore.Mvc;
using FluentValidation.Results;
using Membership.Application.Features.Customers.Commands.Update;

namespace MembershipExample.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : BaseController
    {
        [HttpPost]
        [Route("AddCustomer")]
        public async Task<IActionResult> Add([FromBody] CreateCustomerCommand createCustomerCommand)
        {
            CreateCustomerResponse response = await Mediator!.Send(createCustomerCommand);
            return Ok(response);
        }
        
        [HttpGet]
        [Route("GetByIdCustomer")]
        public async Task<IActionResult> GetByUserId([FromQuery] GetByUserIdCustomerQuery request)
        {
            var response = await Mediator!.Send(request);
            return Ok(response);
        }

        [HttpPut]
        [Route("UpdateCustomer")]
        public async Task<IActionResult> UpdateCustomer([FromBody] UpdatedCustomerCommand request)
        {
            var response = await Mediator!.Send(request);
            if (response == null)
                return BadRequest("Customer not found or error occurred.");
            return Ok(response);
        }
    }
}
