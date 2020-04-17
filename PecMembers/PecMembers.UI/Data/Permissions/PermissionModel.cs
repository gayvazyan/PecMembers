using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PecMembers.UI.Data.Permissions
{
    public class PermissionModel
    {
        public int Id { get; set; }
        public string PageName { get; set; }
        public string PageArmenianName { get; set; }
        public bool Admin { get; set; }
        public bool Party { get; set; }
        public bool Tec { get; set; }
    }
}
