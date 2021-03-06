﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PecMembers.UI.Model
{
    public partial class Party
    {
        [Key]
        [Column("PartyID")]
        public int PartyId { get; set; }
        [Required]
        [StringLength(255)]
        public string PartyName { get; set; }
    }
}
