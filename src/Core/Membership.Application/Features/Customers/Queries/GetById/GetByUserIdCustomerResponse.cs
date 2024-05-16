namespace Membership.Application.Features.Customers.Queries.GetById
{
    public class GetByUserIdCustomerResponse
    {
        public int UserId { get; set; } = default!;
        public string FirstName { get; set; } = default!;
        public string LastName { get; set; } = default!;
    }
}
