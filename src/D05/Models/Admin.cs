using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace D05.Models
{
    public class Admin
    {

        [ScaffoldColumn(false)]
        public int AdminID { get; set; }

        [Required]
        public string EmailID { get; set; }

        [Required]
        [Range(1, 30)]
        public string Password { get; set; }

    }
}
