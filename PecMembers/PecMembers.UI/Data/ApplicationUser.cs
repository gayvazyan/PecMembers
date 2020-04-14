using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PecMembers.UI.Data
{
    public class ApplicationUser: IdentityUser
    {
        public string UName { get; set; }
        public string PName { get; set; }
    }
}
