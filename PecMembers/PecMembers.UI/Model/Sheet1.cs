using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PecMembers.UI.Model
{
    [Table("Sheet1$")]
    public partial class Sheet1
    {
        public double? F1 { get; set; }
        [StringLength(255)]
        public string F2 { get; set; }
        [StringLength(255)]
        public string F3 { get; set; }
        [StringLength(255)]
        public string F4 { get; set; }
        [StringLength(255)]
        public string F5 { get; set; }
        [StringLength(255)]
        public string F6 { get; set; }
        [StringLength(255)]
        public string F7 { get; set; }
        [StringLength(255)]
        public string F8 { get; set; }
        [StringLength(255)]
        public string F9 { get; set; }
        [StringLength(255)]
        public string F10 { get; set; }
        [StringLength(255)]
        public string F11 { get; set; }
        [StringLength(255)]
        public string F12 { get; set; }
        public double? F13 { get; set; }
        [StringLength(255)]
        public string F14 { get; set; }
    }
}
