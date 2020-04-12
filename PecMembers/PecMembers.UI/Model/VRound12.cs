using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PecMembers.UI.Model
{
    [Table("v_round1_2")]
    public partial class VRound12
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("gr")]
        public double? Gr { get; set; }
        [Column("hhk")]
        public double? Hhk { get; set; }
        [Column("jk")]
        public double? Jk { get; set; }
        [Column("oek")]
        public double? Oek { get; set; }
        [Column("hjd")]
        public double? Hjd { get; set; }
        [Column("bhk")]
        public double? Bhk { get; set; }
    }
}
