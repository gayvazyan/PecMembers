using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PecMembers.UI.Model
{
    [Table("tt2")]
    public partial class Tt2
    {
        [StringLength(3)]
        public string CommunityCode { get; set; }
        [StringLength(64)]
        public string Name { get; set; }
        public int TypeId { get; set; }
    }
}
