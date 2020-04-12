using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PecMembers.UI.Model
{
    [Table("v_group")]
    public partial class VGroup
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("name")]
        [StringLength(255)]
        public string Name { get; set; }
        public double? N { get; set; }
        [Column("size")]
        [StringLength(255)]
        public string Size { get; set; }
        [Column("group")]
        public double? Group { get; set; }
        [Column("t1")]
        public int? T1 { get; set; }
        [Column("t2")]
        public int? T2 { get; set; }
        [Column("t3")]
        public int? T3 { get; set; }
        [Column("t4")]
        public int? T4 { get; set; }
        [Column("t5")]
        public int? T5 { get; set; }
        [Column("t6")]
        public int? T6 { get; set; }
        [Column("t7")]
        public int? T7 { get; set; }
        [Column("t8")]
        public int? T8 { get; set; }
        [Column("t9")]
        public int? T9 { get; set; }
        [Column("t10")]
        public int? T10 { get; set; }
    }
}
