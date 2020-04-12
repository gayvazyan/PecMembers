using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PecMembers.UI.ViewModel
{
    public class InputeForQueryViewModel
    {
        public string NameParty { get; set; } = string.Empty;
        public DateTime dayElection { get; set; } = DateTime.Now;
        public string dayElectionArm { get; set; } = string.Empty;
        public bool isRep { get; set; } = false;
        public int countMember { get; set; } = 0;
        public int countChairman { get; set; } = 0;
        public int countSecretary { get; set; } = 0;

    }
}
