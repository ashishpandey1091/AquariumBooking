using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace D05.Models
{
    public class Event
    {
        [ScaffoldColumn(false)]
        public int EventID { get; set; }

        [Required]
        [Display(Name = "Event Name")]
        public string EventName { get; set; }

        [Required]
        public string Description { get; set; }


        [Required]
        [Display(Name = "Adult Price")]
        [Range(typeof(decimal), "50.00", "100.00")]
        public decimal AdultPrice { get; set; }


        [Required]
        [Display(Name = "Child Price")]
        [Range(typeof(decimal), "10.00", "20.00")]
        public decimal ChildPrice { get; set; }


        [Required]
        [Display(Name = "OldAge Price")]
        [Range(typeof(decimal), "5.00", "10.99")]
        public decimal OldAgePrice { get; set; }


        [Required]
        [Display(Name = "SpecialEvent")]
        public bool IsSpecialEvent { get; set; }

        
        [Display(Name = "Event Date")]
        public DateTime EventDate { get; set; }

        
        [Display(Name = "Event Start Time")]
        public string EventStartTime { get; set; }

        
        [Display(Name = "Event End Time")]
        public string EventEndTime { get; set; }
    }
}
