using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace D05.Models
{
    public class BirthdayParties
    {

        [ScaffoldColumn(false)]
        [Key]
        public int Birthday_Id { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(20)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(20)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [MinLength(10)]
        [MaxLength(10)]
        public int Phone { get; set; }

        [Required]
        public EmailAddressAttribute Email { get; set; }

        [Required]
        [Display(Name = "Birth Person Name")]
        public string BirthdayPersonName { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(3)]
        [Display(Name = "Person Age")]
        public int PersonAge { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(3)]
        [Display(Name = "No. Of People")]
        public int NoOfPeople { get; set; }

        [MinLength(1)]
        [MaxLength(250)]
        [Display(Name = "Details / Food")]
        public string DetailsFood { get; set; }

        
        public string isAdminAccepted { get; set; }


    }
}
