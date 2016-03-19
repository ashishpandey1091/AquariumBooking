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
        [Key]
        public int Event_Id { get; set; }

        [Required]
        [Display(Name ="Event Name")]
        [MaxLength(150 , ErrorMessage = "Maximum Length of the Event Name should not Exceed 150 Characters.")]
        public String EventName { get; set; }

        [Required]
        [Display(Name = "Event Description")]
        [MaxLength(500, ErrorMessage = "Maximum Length of the Event Description should not Exceed 5000 Characters.")]
        public String EventDescription { get; set; }

        [Required]
        [Display(Name ="Adult Price")]
        [Range(0,99 , ErrorMessage = " Price should be in between 0-99 dollars")]
        public Decimal AdultPrice { get; set; }

        [Required]
        [Display(Name = "Older Price")]
        [Range(0, 99, ErrorMessage = " Price should be in between 0-99 dollars")]
        public Decimal OlderAgePrice { get; set; }

        [Required]
        [Display(Name = "Child Price")]
        [Range(0, 99, ErrorMessage = " Price should be in between 0-99 dollars")]
        public Decimal ChildAgePrice { get; set; }

        [Display(Name = "Special Event")]
        public bool isSpecialEvent { get; set; }

        [Display(Name = "Event Date")]
        public DateTime EventDate { get; set; }

        [Display(Name = "Start Time")]
        public String StartTime { get; set; }

        [Display(Name = "End Time")]
        public String EndTime { get; set; }

    }
}
