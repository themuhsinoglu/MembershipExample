using MediatR;
using Membership.Application.Interfaces.UnitOfWorks;

namespace Membership.Application.Features.Customers.Queries.GetById
{
    public class GetByUserIdCustomerQuery : IRequest<GetByUserIdCustomerResponse>
    {
        public Guid Id { get; set; } = default!;

        public class GetByUserIdCustomerQueryHandler : IRequestHandler<GetByUserIdCustomerQuery, GetByUserIdCustomerResponse>
        {
            private readonly IUnitOfWork _unitOfWork;

            public GetByUserIdCustomerQueryHandler(IUnitOfWork unitOfWork)
            {
                _unitOfWork = unitOfWork;
            }

            public async Task<GetByUserIdCustomerResponse> Handle(GetByUserIdCustomerQuery request, CancellationToken cancellationToken)
            {
                var customer = await _unitOfWork.Customers.GetByIdAsync(request.Id);

                GetByUserIdCustomerResponse response = new()
                {
                    UserId = customer.UserId,
                    FirstName = customer.FirstName,
                    LastName = customer.LastName,
                };

                return response;
            }
        }
    }
}
