using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PecMembers.UI.Model
{
    [Table("umModules")]
    public partial class UmModules
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        public int Type { get; set; }
        [StringLength(255)]
        public string Path { get; set; }
        [Column("UKey")]
        public int? Ukey { get; set; }
        [StringLength(255)]
        public string Assambly { get; set; }
        [StringLength(255)]
        public string Object { get; set; }
        [Column("msrepl_tran_version")]
        public Guid MsreplTranVersion { get; set; }
    }
}
