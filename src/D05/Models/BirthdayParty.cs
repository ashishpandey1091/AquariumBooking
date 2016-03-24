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
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public int ContactNumber { get; set; }

        [DataType(DataType.EmailAddress)]
        [Required]
        public string UserEmail { get; set; }

        [Required]
        public string BirthdayPersonName { get; set; }

        [Required]
        public int BirthdayPersonAge { get; set; }

        [Required]
        public DateTime DateofVisit { get; set; }

        [Required]
        public int AttendeesNumber { get; set; }

        public string FoodDetails { get; set; }

        [Required]
        public string IsAdminAccepted { get; set; }


    }
}
