using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PecMembers.UI.Model
{
    public partial class Sheet
    {
        [Column("a")]
        public double? A { get; set; }
        [Column("b")]
        public double? B { get; set; }
        public double? F3 { get; set; }
        [Column("c")]
        [StringLength(255)]
        public string C { get; set; }
        [Column("d ")]
        [StringLength(255)]
        public string D { get; set; }
        [Column("e")]
        [StringLength(255)]
        public string E { get; set; }
    }
}
