using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace D05.Models
{
    public class CouponProfile
    {

        [ScaffoldColumn (false)]
        [Required]
        [Key]public int ProfileID { get; set; }

       
        [ScaffoldColumn (false)]
        [Required]
        public int CouponID { get; set; }

        [Display(Name = "FirstName")]
        public string FirstName { get; set; }

        [Display(Name = "LastName")]
        public string LastName { get; set; }

        public bool isUsed { get; set; }
        
    }
}
