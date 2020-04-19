using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PecMembers.UI.Data.PecMemberModels
{
    public class CurrentElection
    {
        [Key]
        public int Id { get; set; }
       public int ElectionId { get; set; }
        public DateTime ElectionDay { get; set; }
        //public bool IsExtra { get; set; }
        //public bool IsRep { get; set; }
        public DateTime StartInputTime { get; set; }
        public DateTime EndInputTime { get; set; }
    }
}
