using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PecMembers.UI.Model
{
    [Table("v_columns")]
    public partial class VColumns
    {
        [Key]
        [StringLength(32)]
        public string ColumnName { get; set; }
        [StringLength(255)]
        public string Name { get; set; }
    }
}
