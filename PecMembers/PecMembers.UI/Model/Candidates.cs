using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PecMembers.UI.Model
{
    public partial class Candidates
    {
        [Key]
        public int CandidateId { get; set; }
        public int? ElectionId { get; set; }
        public int? DistrictId { get; set; }
        public int? CommissionId { get; set; }
        public int? State { get; set; }
        public int? RecommendationId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ActivityDate { get; set; }
        public bool? IsElected { get; set; }
        [StringLength(128)]
        public string CandidateName { get; set; }
        [Column("msrepl_tran_version")]
        public Guid MsreplTranVersion { get; set; }
        [StringLength(4)]
        public string OrderNum { get; set; }
    }
}
