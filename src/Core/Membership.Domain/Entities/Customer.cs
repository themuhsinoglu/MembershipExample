using System.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using Membership.Domain.Common;

namespace Membership.Domain.Entities
{
    public class Customer:BaseEntity<int>
    {
        public Customer(string userId, DateTime startDate, DateTime endDate, CustomerStatusType status, MembershipType membershipType, PaymentType paymentType, string note)
        {
            UserId = userId;
            StartDate = startDate;
            EndDate = endDate;
            Status = status;
            MembershipType = membershipType;
            PaymentType = paymentType;
            Note = note;
        }

        public string UserId { get; set; } = default!;
        public DateTime StartDate { get; set; } = default!;
        public DateTime EndDate { get; set; } = default!;
        public CustomerStatusType Status { get; set; } = default!;
        public MembershipType MembershipType { get; set; } = default!;
        public PaymentType PaymentType { get; set; }= default!;
        public string Note { get; set; }=default!;

        
    }
}