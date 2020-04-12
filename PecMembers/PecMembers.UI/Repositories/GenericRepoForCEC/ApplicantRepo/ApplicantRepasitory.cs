using PecMembers.UI.Data.PecMemberModels;
using PecMembers.UI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PecMembers.UI.Repositories.GenericRepoForCEC.ApplicantRepo
{
    public class ApplicantRepasitory : GenericRepoForCEC<Applicant>, IApplicantRepasitory
    {
        public ApplicantRepasitory(CecsystemsdbContext dbContext) : base(dbContext)
        {

        }
    }
}
