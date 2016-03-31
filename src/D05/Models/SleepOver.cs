using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace D05.Models
{
    public class SleepOver
    {
        [ScaffoldColumn(false)]
        public int SleepOverID { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Telephone")]
        public string ContactNumber { get; set; }

        [DataType(DataType.EmailAddress)]
        [Required]
        [Display(Name = "Email")]
        public string UserEmail { get; set; }

        [Required]
        [Display(Name = "Date of Visit")]
        public DateTime DateofVisit { get; set; }

        [Required]
        [Display(Name = "Date of Registration")]
        public DateTime DateofRegistration { get; set; }

        [Required]
        [Display(Name = "No. Of People")]
        public int AttendeesNumber { get; set; }

        [Display(Name = "Food")]
        public bool IsNeedInFood { get; set; }
        [Display(Name = "Mattress")]
        public bool IsNeedInMattress { get; set; }
        [Display(Name = "Virtual Reality (Gear VR)")]
        public bool IsNeedInVR { get; set; }

        [Required]
        public string IsAdminAccepted { get; set; }

    }
}
