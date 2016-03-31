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
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public int ContactNumber { get; set; }

        [DataType(DataType.EmailAddress)]
        [Required]
        public string UserEmail { get; set; }

        [Required]
        public DateTime DateofVisit { get; set; }

        [Required]
        public int AttendeesNumber { get; set; }

        public bool IsNeedInFood { get; set; }

        public bool IsNeedInMattress { get; set; }

        public bool IsNeedInVR { get; set; }

        [Required]
        public string IsAdminAccepted { get; set; }


    }
}
