using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace D05.Models
{
    public class Coupon
    {
        [ScaffoldColumn(false)]
        public int CouponID { get; set; }


        [Required]
        [Display(Name = "Coupon Number")]
        public string CouponNumber { get; set; }

        [Required]
        [Display(Name = "Created Date")]
        public DateTime CreatedDate { get; set; }

        [Required]
        [Display(Name = "Expiry Date")]
        public DateTime ExpiryDate { get; set; }

        [Required]
        [Display(Name = "Price Reduced")]
        [Range(typeof(decimal), "50.00", "50.00")]
        public decimal PriceReduced { get; set; }


        //public virtual ICollection<ApplicationUser> ApplicationUsers { get;  set; }
    }
}
