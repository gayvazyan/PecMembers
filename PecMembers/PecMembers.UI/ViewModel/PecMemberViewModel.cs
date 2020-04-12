using PecMembers.UI.Data.PecMemberModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PecMembers.UI.ViewModel
{
    public class PecMemberViewModel 
    {
        public int Id { get; set; }
        public string ElectionDayView { get; set; }
        public string CommunityView { get; set; }
        public string DistrictView { get; set; }
        public string SubDistrictCodeView { get; set; }
        public string FullName { get; set; }
        public string PartyView { get; set; }
        public string CerteficateView { get; set; }
        public string PhoneNumberView { get; set; }
        public string PositionView { get; set; }
        public bool IsEmpty { get; set; }

    }
}
