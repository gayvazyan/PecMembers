using PecMembers.UI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PecMembers.UI.Repositories.GenericRepoForCEC.OldCerteficateRepo
{
    public class OldCerteficateRepository : GenericRepoForCEC<OldCerteficate>, IOldCerteficateRepository
    {
        public OldCerteficateRepository(CecsystemsdbContext dbContext) : base(dbContext)
        {

        }
    }
}
