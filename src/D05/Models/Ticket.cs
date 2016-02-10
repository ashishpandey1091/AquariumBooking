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
        public int TicketID { get; set; }
        [Required]
        public string TicketType { get; set; }
       
        [Range(1, 200)]
        public DateTime VisitReason { get; set; }
        [Required]
        public DateTime VisitingTime { get; set; }
        [Required]
        public DateTime VisitingDate { get; set; }
        [Required]
        public DateTime TicketGeneratedDate { get; set; }
<<<<<<< HEAD
       // [ScaffoldColumn(false)]
       // public int TransactionID { get; set; }

        // Navigation property
       // public virtual Transaction Transaction { get; set; }
=======
        [ScaffoldColumn(false)]
        public int TransactionID { get; set; }

        // Navigation property
        public virtual Transaction Transaction { get; set; }
>>>>>>> 46765467cfe76bab7016517f3b77c7e1e129e80b


    }
}
