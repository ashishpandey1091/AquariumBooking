using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace D05.Models
{
    public class Transaction
    {
        [ScaffoldColumn(false)]
        public int TransactionID { get; set; }


        public DateTime CreatedDate { get; set; }
        [Required]
        public int ProfileID { get; set; }
        public double TotalAmount { get; set; }
        public double PaidAmount { get; set; }
        public string UsedCoupon { get; set; }


        [Required]
        public string TicketType { get; set; }

        public double ToTalAmnt { get; set; }

        public double PaidAmnt { get; set; }

        [ScaffoldColumn(false)]
        public int ProfileId { get; set; }

        // Navigation property
        // public virtual Profile Profile { get; set; }

    }
}
