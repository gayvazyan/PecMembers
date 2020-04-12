﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PecMembers.UI.Model
{
    public partial class Communitis1
    {
        [Required]
        [StringLength(3)]
        public string CommunityCode { get; set; }
        [StringLength(2)]
        public string RegionCode { get; set; }
        [StringLength(64)]
        public string Name { get; set; }
    }
}