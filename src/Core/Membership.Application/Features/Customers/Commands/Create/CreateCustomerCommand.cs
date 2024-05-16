using MediatR;
using Membership.Application.Interfaces.UnitOfWorks;
using Membership.Domain;
using Membership.Domain.Entities;

namespace Membership.Application.Features.Customers.Commands.Create
{
    public class CreateCustomerCommand : IRequest<CreateCustomerResponse>
    {
        public string FirstName { get; set; } = default!;
        public string LastName { get; set; } = default!;
        public int UserId { get; set; } = default!;
        public DateTime StartDate { get; set; } = default!;
        public MembershipType MembershipType { get; set; } = default!;
        public string? Note { get; set; } = default!;

        public class CreateCustomerCommandHandler : IRequestHandler<CreateCustomerCommand, CreateCustomerResponse>
        {
            private readonly IUnitOfWork _unitOfWork;

            public CreateCustomerCommandHandler(IUnitOfWork unitOfWork)
            {
                _unitOfWork = unitOfWork;
            }

            public async Task<CreateCustomerResponse> Handle(CreateCustomerCommand request, CancellationToken cancellationToken)
            {

                Customer customer = new();

                customer.FirstName = request.FirstName;
                customer.LastName = request.LastName;
                customer.UserId = request.UserId;
                customer.StartDate = request.StartDate;
                customer.EndDate = request.StartDate.AddYears(1);
                customer.MembershipType = request.MembershipType;

                if (!string.IsNullOrEmpty(request.Note))
                {
                    customer.Note = request.Note;
                }

                customer = await _unitOfWork.Customers.AddAsync(customer);

                CreateCustomerResponse response = new()
                {
                    Id = customer.Id.ToString()!,
                    FirstName = customer.FirstName,
                    LastName = customer.LastName,
                    StartDate = customer.StartDate,
                    EndDate = customer.EndDate,
                };


                return response;
            }
        }
    }
}
