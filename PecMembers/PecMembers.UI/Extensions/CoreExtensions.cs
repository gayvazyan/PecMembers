using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PecMembers.UI.Model;
using PecMembers.UI.Repositories.GenericRepoForElections;
using PecMembers.UI.Repositories.GenericRepoForCEC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PecMembers.UI.Repositories.CommunitisRepo;
using PecMembers.UI.Services.DistrictsRepo;
using PecMembers.UI.Services.PecMemberElectResultRepo;
using PecMembers.UI.Repositories.GenericRepoForCEC.ApplicantRepo;
using PecMembers.UI.Repositories.ElectionsRepo;
using PecMembers.UI.Repositories.PartisInfoRepo;
using PecMembers.UI.Repositories.GenericRepoForPecMembers;
using PecMembers.UI.Repositories.GenericRepoForPecMembers.PecMembersCurrentRepo;
using PecMembers.UI.Data;
using Microsoft.AspNetCore.Identity;
using PecMembers.UI.Repositories.GenericRepoForCEC.OldCerteficateRepo;

namespace PecMembers.UI.Extensions
{
    public static partial class CoreExtensions
    {
        public static void ConfigureDbContext(IConfiguration configuration, IServiceCollection services)
        {
            services.AddDbContext<ElectionsContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("ElectionsDbConnection")));

            services.AddDbContext<CecsystemsdbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("CecsystemsdbDbConnection")));

            services.AddDbContext<PecMembersDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("PecmembersdbDbConnection")));

         
            services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddRoles<IdentityRole>()
                .AddEntityFrameworkStores<PecMembersDbContext>();


        }
        
        public static void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddTransient(typeof(IGenericRepoForCEC<>), typeof(GenericRepoForCEC<>));
            services.AddTransient(typeof(IGenericRepoPecMember<>), typeof(GenericRepoPecMember<>));

            services.AddTransient<IApplicantRepasitory, ApplicantRepasitory>();
            services.AddTransient<IOldCerteficateRepository, OldCerteficateRepository>();
            

            services.AddTransient<IElectionsRepo, ElectionsRepo>();
            services.AddTransient<IPecMemberElectResultRepo, PecMemberElectResultRepo>();
            services.AddTransient<ICommunitisRepo, CommunitisRepo>();
            services.AddTransient<IDistrictsRepo, DistrictsRepo>(); 
            services.AddTransient<IPartisInfoRepo, PartisInfoRepo>();


            services.AddTransient<IPecMembersCurrentRepos, PecMembersCurrentRepos>();
            

        }
    }
}