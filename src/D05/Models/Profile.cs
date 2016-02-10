using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace D05.Models
{
    public class Profile
    {

        [ScaffoldColumn(false)]
        public int ProfileID { get; set; }
        [Required][Range(1,50)]
        public string FirstName { get; set; }
        [Required][Range(1,50)]
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required][Range(1,2)]
        public int Age { get; set; }
        [Required]
        [Range(1, 30)]
        public string Password { get; set; }
        [Required]
        [Range(1, 200)]
        public string Question { get; set; }
        [Required]
        [Range(1, 50)]
        public string Answer { get; set; }
        [Required]
        [Range(1, 6)]
        public string PersonalCoup { get; set; }

        //public virtual ICollection<CouponProfile> CouponProfiles { get; set; }

       // public virtual ICollection<Transaction> Transactions { get; set; }

    }
}
