using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace D05.Models
{
    public class OrderDetails
    {
        [ScaffoldColumn(false)]
        public int OrderDetailsID { get; set; }

        [Required]
        public DateTime DateOfVisit { get; set; }

        [Required]
        [Range(typeof(decimal), "5.00", "10000.00")]
        public decimal EntryTicketPrice { get; set; }

        [Required]
        [Range(typeof(decimal), "5.00", "10000.00")]
        public decimal SpecialEventPrice { get; set; }

        [Required]
        [Range(typeof(decimal), "5.00", "10000.00")]
        public decimal OrderTotalPrice { get; set; }

        [Required]
        public DateTime TicketGeneratedDate { get; set; }

        [Required]
        [RegularExpression(@"^[a-zA-Z”-‘\s]{1,40}$")]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string EmailID { get; set; }

        [Required]
        public int ContactNumber { get; set; }

        [DataType(DataType.CreditCard)]
        public object CCnum { get; set; }

    }
}
