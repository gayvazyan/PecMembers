using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PecMembers.UI.Data.PecMemberModels
{
    public class PecMembersCurrent 
    {
        public int Id { get; set; }
        public int? DistrictId { get; set; }
        public int? SubDistrictCode { get; set; }
        public string Name { get; set; }
        public string SubDistrict { get; set; }
        public int WorkPositionId { get; set; }
        public string WorkPosition { get; set; }
        public DateTime ElectionDay { get; set; }
        public DateTime CreatedDay { get; set; }
        public string PartyName { get; set; }
        public bool IsEmpty { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string FullName => LastName + " " + FirstName + " " + MiddleName;
        public string Passport { get; set; }
        public string Certeficate { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Adress { get; set; }
        public string SSN { get; set; }
        public int  ElectionId { get; set; }

    }
}
