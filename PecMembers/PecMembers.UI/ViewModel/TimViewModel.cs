using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PecMembers.UI.ViewModel
{
    public class TimViewModel
    {
        public int? DistrictId { get; set; }
        public int? SubDistrictCode { get; set; }
        public string Name { get; set; }
        public string SubDistrict { get; set; }
        public int WorkPositionId { get; set; }
        public string WorkPosition { get; set; }
    }
}
