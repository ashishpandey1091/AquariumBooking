using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace D05.Models
{
    public class Price
    {
        [ScaffoldColumn(false)]
        public int PriceID { get; set; }

        [Required]
        [Range(typeof(decimal), "50.00", "100.00")]
        public decimal AdultPrice { get; set; }

        [Required]
        [Range(typeof(decimal), "20.00", "30.00")]
        public decimal ChildPrice { get; set; }

        [Required]
        [Range(typeof(decimal), "5.00", "10.00")]
        public decimal OldAgePrice { get; set; }
    }
}
