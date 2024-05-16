namespace Membership.Domain.Common
{
    abstract public class BaseEntity
    {
        public BaseEntity()
        {
            Id = Guid.NewGuid();
            CreatedDate = DateTime.Now;
        }

        public Guid? Id { get; set; } = default!;
        public DateTime CreatedDate { get; set; } = default!;
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }

    }
}