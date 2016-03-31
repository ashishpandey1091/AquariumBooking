using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace D05.Models
{
    public class SchoolTrip
    {
        [ScaffoldColumn(false)]
        public int SchoolTripID { get; set; }

        [Required]
        [Display(Name = "School Name")]
        public string SchoolName { get; set; }

        [Required]
        [Display(Name = "School Address")]
        public string SchoolAddress { get; set; }

        [Required]
        [Display(Name = "Telephone")]
        public string ContactNumber { get; set; }

        [DataType(DataType.EmailAddress)]
        [Required]
        [Display(Name = "Email")]
        public string SchoolEmail { get; set; }

        [Required]
        [Display(Name = "Number of Children")]
        public int NoOfChildren { get; set; }

        [Required]
        [Display(Name = "Number of Adults")]
        public int NoOfAdults { get; set; }

        [Required]
        [Display(Name = "Date of visit")]
        public DateTime DateofVisit { get; set; }



        [Required]
        [Display(Name = "Details")]
        public string Details { get; set; }

        [Required]
        public string IsAdminAccepted { get; set; }

        [Required]
        [Display(Name = "Date of Registration")]
        public DateTime DateofRegistration { get; set; }


    }
}
