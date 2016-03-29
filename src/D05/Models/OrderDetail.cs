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

        
        public int AdultTicketQty { get; set; }

        
        public int ChildTicketQty { get; set; }

        
        public int OldAgeTicketQty { get; set; }


        [Required]
        public decimal EntryTicketPrice { get; set; }

        
        public decimal SpecialEventPrice { get; set; }

        public string SpecialShowName1 { get; set; }      

        public int ShowCount { get; set; } 


        [Required]
        public decimal OrderTotalPrice { get; set; }

        [Required]
        public DateTime TicketGeneratedDate { get; set; }

        [DataType(DataType.EmailAddress)]
        public string VisitorEmail { get; set; }

        public string VisitorFN { get; set; }

        public string VisitorLN { get; set; }

        public string ContactNumber { get; set; }

        public int MealQty { get; set; }

        public string Lunch { get; set; }

        public int RideQty { get; set; }

        public string RidePlan { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}
