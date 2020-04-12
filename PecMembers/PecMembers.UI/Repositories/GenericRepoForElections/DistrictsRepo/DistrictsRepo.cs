using PecMembers.UI.Model;
using PecMembers.UI.Repositories.GenericRepoForElections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PecMembers.UI.Services.DistrictsRepo
{
    public class DistrictsRepo : GenericRepository<Districts>, IDistrictsRepo
    {
        public DistrictsRepo(ElectionsContext dbContext) : base(dbContext)
        {

        }
    }
}
