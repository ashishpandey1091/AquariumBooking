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
        [Key]public int ProfileID { get; set; }

        [ScaffoldColumn (false)]
        public int CouponID { get; set; }

        public bool isUsed { get; set; }
        
    }
}
