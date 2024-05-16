namespace Membership.Application.Features.Customers.Commands.Create
{
    public class CreateCustomerResponse
    {

        public string Id { get; set; } = default!;
        public string FirstName { get; set; } = default!;
        public string LastName { get; set; } = default!;
        public DateTime? StartDate { get; set; } = default!;
        public DateTime? EndDate { get; set; } = default!;
    }
}
