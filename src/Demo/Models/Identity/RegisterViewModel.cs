using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.Models.Identity
{
    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name="Email")]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "ComfirmPassword")]
        [Compare("Passwod", ErrorMessage="Password Not Match!")]
        public string ComfirmPassword { get; set; }
    }
}

