using MediatR;
using Membership.Application.Interfaces.UnitOfWorks;
using Membership.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Membership.Application.Features.Customers.Commands.Update
{
    public class UpdatedCustomerCommand : IRequest<UpdatedCustomerResponse>
    {
        public Guid Id { get; set; } = default!;
        public DateTime StartDate { get; set; } = default!;

        public class UpdatedCustomerCommandHandler : IRequestHandler<UpdatedCustomerCommand, UpdatedCustomerResponse>
        {
            private readonly IUnitOfWork _unitOfWork;

            public UpdatedCustomerCommandHandler(IUnitOfWork unitOfWork)
            {
                _unitOfWork = unitOfWork;
            }

            public async Task<UpdatedCustomerResponse> Handle(UpdatedCustomerCommand request, CancellationToken cancellationToken)
            {
                Customer? customer = await _unitOfWork.Customers.GetByIdAsync(request.Id);

                if (customer == null)
                {
                    return null;
                }

                customer.StartDate = request.StartDate;
                customer.EndDate = request.StartDate.AddYears(1);
                customer.ModifiedDate = DateTime.Now;

                customer = await _unitOfWork.Customers.UpdateAsync(customer);

                UpdatedCustomerResponse response = new()
                {
                    Id = customer.Id.ToString()!,
                    FirstName = customer.FirstName,
                    LastName = customer.LastName,
                    StartDate = customer.StartDate,
                    EndDate = customer.EndDate
                };

                return response;


            }
        }
    }
}
