using PecMembers.UI.Data;
using PecMembers.UI.Data.PecMemberModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PecMembers.UI.Repositories.GenericRepoForPecMembers.CurrentElectionRepo
{
    public class CurrentElectionRepo : GenericRepoPecMember<CurrentElection>, ICurrentElectionRepo
    {
        public CurrentElectionRepo(PecMembersDbContext dbContext) : base(dbContext)
        {

        }
    }
}
