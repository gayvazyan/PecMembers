using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PecMembers.UI.Model
{
    [Table("v_result")]
    public partial class VResult
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [StringLength(255)]
        public string Name { get; set; }
        [StringLength(255)]
        public string N { get; set; }
        [Column("HHK")]
        [StringLength(255)]
        public string Hhk { get; set; }
        [Column("JK")]
        [StringLength(255)]
        public string Jk { get; set; }
        [Column("OEK")]
        [StringLength(255)]
        public string Oek { get; set; }
        [Column("HJD")]
        [StringLength(255)]
        public string Hjd { get; set; }
        [Column("BHK")]
        [StringLength(255)]
        public string Bhk { get; set; }
    }
}
