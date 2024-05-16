using FluentValidation;
using Membership.Application.Features.Customers.Commands.Create;

namespace Membership.Application.Features.Customers.Rules
{
    public class CreateCustomerCommandValidator : AbstractValidator<CreateCustomerCommand>
    {
        public CreateCustomerCommandValidator()
        {
            RuleFor(c => c.FirstName).NotEmpty().Matches("^[a-zA-Z]+$").WithMessage("Name is required or Invalid firstName");

            RuleFor(c => c.LastName).NotEmpty().Matches("^[a-zA-Z]+$").WithMessage("Name is required or Invalid lastname");

            RuleFor(c => c.UserId).InclusiveBetween(1000, 9999)
            .WithMessage("Only 4 digit numbers.");

            //RuleFor(c => c.MembershipType).InclusiveBetween(0, 2)
            //.WithMessage("0 = Standart / 1 = Premium / 2 = Gold");
        }

    }
}
