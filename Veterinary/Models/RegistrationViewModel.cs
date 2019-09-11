using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;

namespace Veterinary.Models
{
    public class RegistrationViewModel
    {
        [Required(ErrorMessage = " {0} არის აუცილებელი")]
        public string name { get; set; }
        [Required(ErrorMessage = " {0} არის აუცილებელი")]
        public string surName { get; set; }
        [Required(ErrorMessage = " {0} არის აუცილებელი")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MMM/yyyy}")]
        public string birthdate { get; set; }
        [Required(ErrorMessage = " {0} არის აუცილებელი")]
        public string dog_breed { get; set; }
        [Required(ErrorMessage = " {0} არის აუცილებელი")]
        public string mail { get; set; }
        [Required(ErrorMessage = " {0} არის აუცილებელი")]
        public string password { get; set; }
        [Required(ErrorMessage = " {0} არის აუცილებელი")]
        public string repeatPassword { get; set; }
    }
}