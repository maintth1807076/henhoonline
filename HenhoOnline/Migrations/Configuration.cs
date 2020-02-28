﻿using HenhoOnline.Models;

namespace HenhoOnline.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<HenhoOnline.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            AutomaticMigrationDataLossAllowed = true;
            ContextKey = "HenhoOnline.Models.ApplicationDbContext";
        }

        protected override void Seed(HenhoOnline.Models.ApplicationDbContext context)
        {
            //context.Database.ExecuteSqlCommand("DBCC CHECKIDENT('dbo.TuVis', RESEED, 1)");
            context.TuVis.AddOrUpdate(x => x.Id,
                new TuVi() { Id = 1, StartDate = "05/12/1999", EndDate = "05/01/2000", Tuoi = "Canh Thìn", Menh = "Kim", TuoiHop = "Mậu Thìn, Nhân Thân, Giáp Tuất, Bính Dần", Gender = 1 },
                new TuVi() { Id = 2, StartDate = "05/12/1999", EndDate = "05/12/1999", Tuoi = "Canh Thìn", Menh = "Kim", TuoiHop = "", Gender = 1 }
            );
            context.Users.AddOrUpdate(x => x.Id,
                new ApplicationUser() { Id = "1", UserName = "mai1", EmailConfirmed = false, PhoneNumberConfirmed = false, TwoFactorEnabled = false, LockoutEnabled = true, AccessFailedCount = 0, FullName = "MaiNe", Gender = 1, BirthDay = DateTime.Parse("05/12/1999"), Avatar = "", Address = "Hà Nội", Character = ApplicationUser.CharacterType.Funny },
                new ApplicationUser() { Id = "2", UserName = "mai2", EmailConfirmed = false, PhoneNumberConfirmed = false, TwoFactorEnabled = false, LockoutEnabled = true, AccessFailedCount = 0, FullName = "MaiNe", Gender = 1, BirthDay = DateTime.Parse("05/12/1999"), Avatar = "", Address = "Hà Nội", Character = ApplicationUser.CharacterType.Funny }

                
                );
        }
    }
}
