using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Membership.Domain.Common
{
    public class BaseEntity<T>
    {
        public BaseEntity()
        {
          Id = default!;
        }
        public T Id { get; set; } = default!;
        public DateTime CreatedDate { get; set; } = default!;
        public DateTime? ModifiedDate { get; set; } 
        public DateTime? DeletedDate { get; set; }

    }
}