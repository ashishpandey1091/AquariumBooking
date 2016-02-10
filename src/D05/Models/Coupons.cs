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
        public int CouponID { get; set; }

        public string CouponString { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime ExpireDate { get; set; }
    }
}
