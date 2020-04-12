using PecMembers.UI.Model;
using PecMembers.UI.Repositories.GenericRepoForElections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PecMembers.UI.Repositories.ElectionsRepo
{
    public interface IElectionsRepo : IGenericRepository<Elections>
    {
    }
}
