using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace D05.Controllers
{
    public class Coupons
    {
        [ScaffoldColumn(false)]
        [Key]public int CouponID { get; set; }

        [Required]
        [MaxLength(8)]
        [MinLength(8)]
        [Display(Name = "Coupon Code")]
        public string CouponCode { get; set; }

        [Required]
        public DateTime CreatedDate { get; set; }
        [Required]
        public DateTime ExpireDate { get; set; }

        [Required]
        [Range(0.01,99.99 , ErrorMessage = "Please enter Valid Discount Price in Dollars and with atleast 0.01 Dollars.")]
        public Decimal priceReduced { get; set; }
    }
}
