using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PecMembers.UI.Model
{
    [Table("cucak_u")]
    public partial class CucakU
    {
        [Column("AZG")]
        [StringLength(60)]
        public string Azg { get; set; }
        [Column("ANUN")]
        [StringLength(60)]
        public string Anun { get; set; }
        [Column("HAYR")]
        [StringLength(255)]
        public string Hayr { get; set; }
        [StringLength(10)]
        public string Bdate { get; set; }
        [Column("REG")]
        [StringLength(40)]
        public string Reg { get; set; }
        [StringLength(255)]
        public string Hamaynq { get; set; }
        [Column("POXOC")]
        [StringLength(100)]
        public string Poxoc { get; set; }
        [Column("TUN")]
        [StringLength(20)]
        public string Tun { get; set; }
        [Column("BNAK")]
        [StringLength(20)]
        public string Bnak { get; set; }
        [Column("TARACQ")]
        [StringLength(10)]
        public string Taracq { get; set; }
        [Column("te_HASCE")]
        [StringLength(255)]
        public string TeHasce { get; set; }
        [Column("numb")]
        [StringLength(255)]
        public string Numb { get; set; }
        [Column("texamas")]
        [StringLength(10)]
        public string Texamas { get; set; }
        public int VoterId { get; set; }
    }
}
