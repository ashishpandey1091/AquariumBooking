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
       [Key] public int EventID { get; set; }
        [Required]
        [Range(1, 50)]
        public string EventName { get; set; }
        [Required]
        [Range(1, 200)]
        public string Description { get; set; }
        [Required]
        [Range(4, 2)]
<<<<<<< HEAD
        public string AdultPrice { get; set; }
        [Required]
        [Range(4, 2)]
        public int SeniorCitizen { get; set; }
        [Required]
        [Range(4, 2)]
        public string Child { get; set; }
=======
        public double AdultPrice { get; set; }
        [Required]
        [Range(4, 2)]
        public double SeniorCitizen { get; set; }
        [Required]
        [Range(4, 2)]
        public double Child { get; set; }
>>>>>>> 46765467cfe76bab7016517f3b77c7e1e129e80b
        public bool SpecialEvent { get; set; }
        

    }
}
