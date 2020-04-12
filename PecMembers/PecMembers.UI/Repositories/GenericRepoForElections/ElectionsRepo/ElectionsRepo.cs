using PecMembers.UI.Model;
using PecMembers.UI.Repositories.GenericRepoForElections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PecMembers.UI.Repositories.ElectionsRepo
{
    public class ElectionsRepo : GenericRepository<Elections>, IElectionsRepo
    {
        public ElectionsRepo(ElectionsContext dbContext) : base(dbContext)
        {

        }
    }
}
