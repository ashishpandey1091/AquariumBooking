using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace D05.Models
{
    public class OrderDetail
    {
        [ScaffoldColumn(false)]
        public int OrderDetailID { get; set; }

        [Required]
        public DateTime DateOfVisit { get; set; }

        [Required]
        public decimal EntryTicketPrice { get; set; }

        [Required]
        public decimal SpecialEventPrice { get; set; }

        [Required]
        public decimal OrderTotalPrice { get; set; }

        [Required]
        public DateTime TicketGeneratedDate { get; set; }

        [DataType(DataType.EmailAddress)]
        public string VisitorEmail { get; set; }

        public string VisitorFN { get; set; }

        public int ContactNumber { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}
