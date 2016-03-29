﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace D05.ViewModels.Account
{
    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get;  set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get;  set; }

        public int Age { get;  set; }

        [Required]
        [Display(Name = "Question")]
        public string Question { get;  set; }

        [Required]
        [Display(Name = "Answer")]
        public string Answer { get;  set; }

        [Required]
        [Display(Name = "Contact Number")]
        public string ContactNumber { get; set; }
    }
}
