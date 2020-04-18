using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PecMembers.UI.Data.PecMemberModels;
using PecMembers.UI.Data.Permissions;

namespace PecMembers.UI.Data
{
    public class PecMembersDbContext : IdentityDbContext<ApplicationUser>
    {
        public PecMembersDbContext(DbContextOptions<PecMembersDbContext> options)
            : base(options)
        {
        }
        public DbSet<PecMembersCurrent> PecMembersCurrentDb { get; set; }
        //public DbSet<PermissionModel> PermissionModelDb { get; set; }


        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);

        //    modelBuilder.Entity<PermissionModel>().HasData(
        //         new PermissionModel
        //         {
        //             Id = 1,
        //             PageName = "Index",
        //             PageArmenianName= "Սկիզբ",
        //             Admin = true,
        //             Party = false,
        //             Tec = false
        //         },
        //          new PermissionModel
        //          {
        //              Id = 2,
        //              PageName = "PecMembersGen",
        //              PageArmenianName = "ՏԸՀ կազմ(գենեռացնել)",
        //              Admin = true,
        //              Party = false,
        //              Tec = false
        //          },
        //           new PermissionModel
        //           {
        //               Id = 3,
        //               PageName = "PecMemberReports",
        //               PageArmenianName = "ՏԸՀ կազմ(պահպանել)",
        //               Admin = true,
        //               Party = false,
        //               Tec = false
        //           },
        //            new PermissionModel
        //            {
        //                Id = 4,
        //                PageName = "PecMembersTec",
        //                PageArmenianName = "ՏԸՀ ընտր․ Դիտել",
        //                Admin = true,
        //                Party = false,
        //                Tec = false
        //            },
        //             new PermissionModel
        //             {
        //                 Id = 5,
        //                 PageName = "PecMembersAdd",
        //                 PageArmenianName = "ՏԸՀ ընտր․ Ավելացնել",
        //                 Admin = true,
        //                 Party = false,
        //                 Tec = false
        //             },
        //              new PermissionModel
        //              {
        //                  Id = 6,
        //                  PageName = "PecMembersEdit",
        //                  PageArmenianName = "ՏԸՀ ընտր․ Խմբագրել",
        //                  Admin = true,
        //                  Party = false,
        //                  Tec = false
        //              },
        //               new PermissionModel
        //               {
        //                   Id = 7,
        //                   PageName = "PecMembersParty",
        //                   PageArmenianName = "ՏԸՀ կուսակց․ Դիտել",
        //                   Admin = true,
        //                   Party = false,
        //                   Tec = false
        //               },
        //               new PermissionModel
        //               {
        //                   Id = 8,
        //                   PageName = "PecMembersPartyAdd",
        //                   PageArmenianName = "ՏԸՀ կուսակց․ Լրացնել",
        //                   Admin = true,
        //                   Party = false,
        //                   Tec = false
        //               },
        //                 new PermissionModel
        //                 {
        //                     Id = 9,
        //                     PageName = "PecMembersPartyEdit",
        //                     PageArmenianName = "ՏԸՀ կուսակց․ Խմբագրել",
        //                     Admin = true,
        //                     Party = false,
        //                     Tec = false
        //                 }

        //        );

        //}
    }
}
