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

        public string CouponString { get; set; }
        [Required]
        public DateTime CreatedDate { get; set; }
        [Required]
        public DateTime ExpireDate { get; set; }
    }
}
