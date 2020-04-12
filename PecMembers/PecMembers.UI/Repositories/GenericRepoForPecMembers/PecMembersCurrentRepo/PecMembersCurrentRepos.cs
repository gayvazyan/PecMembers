using PecMembers.UI.Data;
using PecMembers.UI.Data.PecMemberModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PecMembers.UI.Repositories.GenericRepoForPecMembers.PecMembersCurrentRepo
{
    public class PecMembersCurrentRepos : GenericRepoPecMember<PecMembersCurrent>, IPecMembersCurrentRepos
    {
        public PecMembersCurrentRepos(PecMembersDbContext dbContext) : base(dbContext)
        {

        }
    }
}
