using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PecMembers.UI.Model
{
    [Table("ECucak")]
    public partial class Ecucak
    {
        [StringLength(255)]
        public string Azganun { get; set; }
        [StringLength(255)]
        public string Anun { get; set; }
        [StringLength(255)]
        public string Hayr { get; set; }
        [StringLength(255)]
        public string Born { get; set; }
        [StringLength(255)]
        public string Marz { get; set; }
        [StringLength(255)]
        public string Hamaynq { get; set; }
        [StringLength(255)]
        public string Poxoc { get; set; }
        [StringLength(255)]
        public string Tun { get; set; }
        [StringLength(255)]
        public string TunTesak { get; set; }
        [StringLength(255)]
        public string Bnak { get; set; }
        [StringLength(255)]
        public string Hasce { get; set; }
        [StringLength(255)]
        public string Taracq { get; set; }
        [StringLength(255)]
        public string Texamas { get; set; }
        [StringLength(255)]
        public string Nshum { get; set; }
    }
}
