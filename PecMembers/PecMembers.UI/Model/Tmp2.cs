using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PecMembers.UI.Model
{
    [Table("tmp2")]
    public partial class Tmp2
    {
        [Column("v")]
        public int? V { get; set; }
        public int ElectionId { get; set; }
        [StringLength(50)]
        public string CommunityCode { get; set; }
        public int? CandidateId { get; set; }
    }
}
