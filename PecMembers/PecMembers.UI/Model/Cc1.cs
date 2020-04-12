using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PecMembers.UI.Model
{
    [Table("cc1")]
    public partial class Cc1
    {
        public int ElectionId { get; set; }
        public int TypeId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime SrartDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EndDate { get; set; }
        public int StateId { get; set; }
        public int? LocalDistrictId { get; set; }
        [StringLength(3)]
        public string CommunityCode { get; set; }
        public bool? VisibleInWeb { get; set; }
        public bool? IsExtra { get; set; }
        [StringLength(3)]
        public string Expr1 { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Expr2 { get; set; }
    }
}
