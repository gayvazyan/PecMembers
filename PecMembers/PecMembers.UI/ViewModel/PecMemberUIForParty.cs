﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PecMembers.UI.ViewModel
{
    public class PecMemberUIForParty
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string Passport { get; set; }
        public string Certeficate { get; set; }
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "Մուտքագրեք էլ հասցեն")]
        [EmailAddress(ErrorMessage ="Մուտքագրեք վավեր էլ հասցե")]
        public string Email { get; set; }
        public string Adress { get; set; }
        public string SSN { get; set; }
    }
}
