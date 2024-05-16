using Membership.Domain.Common;

namespace Membership.Domain.Entities
{
    public class Customer : BaseEntity
    {
        public string FirstName { get; set; } = default!;
        public string LastName { get; set; } = default!;
        public int UserId { get; set; } = default!;
        public DateTime StartDate { get; set; } = default!;
        public DateTime EndDate { get; set; } = default!;
        public MembershipType? MembershipType { get; set; } = default!;
        public string? Note { get; set; } = default!;
    }
}