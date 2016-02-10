using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace D05.Models
{
    public class Ticket
    {

        [ScaffoldColumn(false)]
        [Key]public int TicketID { get; set; }
        [Required]
        public string TicketType { get; set; }
       
        [Range(1, 200)]
        [Required]
        public DateTime VisitReason { get; set; }
        [Required]
        public DateTime VisitingTime { get; set; }
        [Required]
        public DateTime VisitingDate { get; set; }
        [Required]
        public DateTime TicketGeneratedDate { get; set; }

       // [ScaffoldColumn(false)]
       // public int TransactionID { get; set; }

        // Navigation property
       // public virtual Transaction Transaction { get; set; }

        [ScaffoldColumn(false)]
        [Required]
        public int TransactionID { get; set; }

        // Navigation property
        public virtual Transaction Transaction { get; set; }
    }
}
