using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Veterinary.Models
{
    public class RegistrationViewModel
    {
        public string name { get; set; }
        public string surName { get; set; }
        public string birthdate { get; set; }
        public string dog_breed { get; set; }
        public string mail { get; set; }
        public string password { get; set; }
        public string repeatPassword { get; set; }
    }
}