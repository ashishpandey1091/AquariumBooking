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
        public string SchoolName { get; set; }

        [Required]
        public string SchoolAddress { get; set; }

        [Required]
        public int ContactNumber { get; set; }

        [DataType(DataType.EmailAddress)]
        [Required]
        public string  SchoolEmail { get; set; }

        [Required]
        public int NoOfChildren { get; set; }

        [Required]
        public int NoOfAdults { get; set; }

        [Required]
        public DateTime DateofVisit { get; set; }

        [Required]
        public string Details { get; set; }

        [Required]
        public string IsAdminAccepted { get; set; }

        [Required]
        public DateTime DateofRegistration { get; set; }
      

    }
}
