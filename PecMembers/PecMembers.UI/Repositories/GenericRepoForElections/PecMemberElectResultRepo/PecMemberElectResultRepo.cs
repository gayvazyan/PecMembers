using PecMembers.UI.Model;
using PecMembers.UI.Repositories.GenericRepoForElections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PecMembers.UI.Services.PecMemberElectResultRepo
{
    public class PecMemberElectResultRepo : GenericRepository<PecMemberElectResult>, IPecMemberElectResultRepo
    {
        public PecMemberElectResultRepo(ElectionsContext dbContext) : base(dbContext)
        {

        }
    }
}
