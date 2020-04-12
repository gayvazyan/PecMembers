using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PecMembers.UI.Model
{
    public partial class CommissionElect1
    {
        public int CommissionElectId { get; set; }
        public int? CecEmployeeId { get; set; }
        public int? PersonId { get; set; }
        public int? Value { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Date { get; set; }
        public bool? IsValide { get; set; }
    }
}
