using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PecMembers.UI.Data.PecMemberModels;

namespace PecMembers.UI.Data
{
    public class PecMembersDbContext : IdentityDbContext
    {
        public PecMembersDbContext(DbContextOptions<PecMembersDbContext> options)
            : base(options)
        {
        }
        public DbSet<PecMembersCurrent> PecMembersCurrentDb { get; set; }
    }
}
