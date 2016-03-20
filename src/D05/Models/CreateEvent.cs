using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace D05.Models
{
    public class CreateEvent
    {

        [ScaffoldColumn(false)]
       [Key]public int EventID { get; set; }
        [Required]
        [Range(1, 50)]
        public string EventName { get; set; }
        [Required]
        [Range(1, 200)]
        public string Description { get; set; }
        [Required]
        [Range(4, 2)]
        public double AdultPrice { get; set; }
        [Required]
        [Range(4, 2)]
        public double SeniorCitizen { get; set; }
        [Required]
        [Range(4, 2)]
        public double Child { get; set; }
        public bool SpecialEvent { get; set; }
        
    }
}