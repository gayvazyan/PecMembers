using PecMembers.UI.Data.Enums;
using PecMembers.UI.Data.PecMemberModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PecMembers.UI.ViewModel
{
    public class PecMemberUIforTEC
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string Passport { get; set; }
        public string Certeficate { get; set; }
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage ="Մուտքագրեք էլ հասցեն")]
        [EmailAddress(ErrorMessage = "Մուտքագրեք վավեր էլ հասցե")]
        public string Email { get; set; }
        public string Adress { get; set; }
        public string SSN { get; set; }
        public DateTime ElectionDay { get; set; } = DateTime.Now;


        //[GaroSelectidValidation(ErrorMessage = "Ընտրեք համայնքը")]
        //public Commun Commun { get; set; }
        [Required(ErrorMessage = "Ընտրեք համայնքը")]
        public string ComunityName { get; set; }
        public District DistrictId { get; set; }
        //[Range(1, 3000, ErrorMessage = "Մուտքագրեք վավեր տեղամասի համար (>0)")]
        [Required(ErrorMessage = "Ընտրեք տեղամասը")]
        public int SubDistrictCode { get; set; }
    }
}
