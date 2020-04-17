using PecMembers.UI.Data;
using PecMembers.UI.Data.Permissions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PecMembers.UI.Repositories.GenericRepoForPecMembers.PermissionsRepo
{
    public class PermissionsRepo : GenericRepoPecMember<PermissionModel>, IPermissionsRepo
    {
        public PermissionsRepo(PecMembersDbContext dbContext) : base(dbContext)
        {

        }
    }
}
