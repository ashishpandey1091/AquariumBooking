﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace D05.Models
{
    public class Sleepovers
    {


        [ScaffoldColumn(false)]
        [Key]
        public int SleepOver_Id { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(20)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(20)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [MinLength(10)]
        [MaxLength(10)]
        public int Phone { get; set; }

        [Required]
        public EmailAddressAttribute Email { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(3)]
        [Display(Name = "No. Of People")]
        public int NoOfPeople { get; set; }

        
        [Display(Name = "Food")]
        public bool inNeedInFood { get; set; }

        [Display(Name = "Matteress")]
        public bool inNeedInMatress { get; set; }

        [Display(Name = "Virtual Reality(Gear VR)")]
        public bool inNeedInVR { get; set; }

        
        public string isAdminAccepted { get; set; }


    }
}