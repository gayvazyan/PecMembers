using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PecMembers.UI.Model
{
    [Table("v_satisfied")]
    public partial class VSatisfied
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("name")]
        [StringLength(255)]
        public string Name { get; set; }
        public double? N { get; set; }
        [Column("hhk")]
        public double? Hhk { get; set; }
        [Column("jk")]
        public double? Jk { get; set; }
        [Column("oek")]
        public double? Oek { get; set; }
        [Column("hjd")]
        public double? Hjd { get; set; }
        [Column("bhk")]
        [StringLength(255)]
        public string Bhk { get; set; }
    }
}
