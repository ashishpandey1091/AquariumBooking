using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace D05.Models
{
    public class BirthdayParty
    {
        [ScaffoldColumn(false)]
        public int BirthdayPartyID { get; set; }

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
        [Display(Name = "Child Name")]
        public string BirthdayPersonName { get; set; }

        [Required]
        [Display(Name = "Child age")]
        public int BirthdayPersonAge { get; set; }

        [Required]
        [Display(Name = "Occassion Date")]
        public DateTime DateofVisit { get; set; }

        [Required]
        [Display(Name = " Date of Registration")]
        public DateTime DateofRegistration { get; set; }

        [Required]
        [Display(Name = "No. Of People")]
        public int AttendeesNumber { get; set; }

        [Display(Name = "Details/Food")]
        public string FoodDetails { get; set; }


        public string IsAdminAccepted { get; set; }


    }
}
