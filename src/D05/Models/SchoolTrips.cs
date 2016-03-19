using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace D05.Models
{
    public class SchoolTrips
    {

        [ScaffoldColumn(false)]
        [Key]
        public int SchoolTrips_Id { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(50)]
        [Display(Name = "School Name")]
        public string SchoolName { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(150)]
        [Display(Name = "School Address")]
        public string SchoolAddress { get; set; }

        [Required]
        [MinLength(10)]
        [MaxLength(10)]
        public int Phone { get; set; }

        [Required]
        public EmailAddressAttribute Email { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(3)]
        [Display(Name = "No. Of. Children")]
        public int NoOfChildren { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(3)]
        [Display(Name = "No. Of. Adults")]
        public int Adults { get; set; }

        [MinLength(1)]
        [MaxLength(250)]
        public string Details { get; set; }

        
        public string isAdminAccepted { get; set; }

    }
}
