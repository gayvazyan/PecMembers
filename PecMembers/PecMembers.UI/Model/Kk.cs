using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PecMembers.UI.Model
{
    [Table("kk")]
    public partial class Kk
    {
        public int OrgId { get; set; }
        [StringLength(255)]
        public string Name { get; set; }
        [Column("expr")]
        public int? Expr { get; set; }
    }
}
