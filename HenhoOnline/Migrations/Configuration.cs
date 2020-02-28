using HenhoOnline.Models;

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
            context.Database.ExecuteSqlCommand("DBCC CHECKIDENT('dbo.TuVis', RESEED, 0)");
            context.Users.AddOrUpdate(x => x.Id,
                new TuVi() { Id = 1, StartDate = DateTime.Parse("1990/01/27"), EndDate = DateTime.Parse("1991/02/14"), NegativeAge = "Canh Ngọ", FiveElements = "Thủy", HoroscopeMatch = "28,29", Gender = 1 },
                new TuVi() { Id = 2, StartDate = DateTime.Parse("1991/02/15"), EndDate = DateTime.Parse("1992/02/02"), NegativeAge = "Tận Mùi", FiveElements = "Hỏa", HoroscopeMatch = "21,24,27", Gender = 1 },
                new TuVi() { Id = 3, StartDate = DateTime.Parse("1992/02/04"), EndDate = DateTime.Parse("1993/01/22"), NegativeAge = "Nhâm Thân",FiveElements = "Thổ", HoroscopeMatch = "37,32", Gender = 1 },
                new TuVi() { Id = 4, StartDate = DateTime.Parse("1993/01/23"), EndDate = DateTime.Parse("1994/02/09"), NegativeAge = "Quý Dậu", FiveElements = "Kim", HoroscopeMatch = "24,26,30", Gender = 1 },
                new TuVi() { Id = 5, StartDate = DateTime.Parse("1994/02/10"), EndDate = DateTime.Parse("1995/01/30"), NegativeAge = "Giáp Tuất", FiveElements = "Kim", HoroscopeMatch = "27,29,33", Gender = 1 },
                new TuVi() { Id = 6, StartDate = DateTime.Parse("1995/02/01"), EndDate = DateTime.Parse("1996/02/18"), NegativeAge = "Ất Hợi", FiveElements = "Thổ", HoroscopeMatch = "28,25", Gender = 1 },
                new TuVi() { Id = 7, StartDate = DateTime.Parse("1996/02/19"), EndDate = DateTime.Parse("1997/02/06"), NegativeAge = "Bính Tý", FiveElements = "Mộc", HoroscopeMatch = "27,36", Gender = 1 },
                new TuVi() { Id = 8, StartDate = DateTime.Parse("1997/02/07"), EndDate = DateTime.Parse("1998/01/27"), NegativeAge = "Đinh Sửu", FiveElements = "Mộc", HoroscopeMatch = "38", Gender = 1 },
                new TuVi() { Id = 9, StartDate = DateTime.Parse("1998/01/28"), EndDate = DateTime.Parse("1999/02/15"), NegativeAge = "Mậu Dần", FiveElements = "Thổ", HoroscopeMatch = "40", Gender = 1 },
                new TuVi() { Id = 10, StartDate = DateTime.Parse("1999/02/16"), EndDate = DateTime.Parse("2000/02/04"), NegativeAge = "Kỷ Mão", FiveElements = "Thủy", HoroscopeMatch = "29,32,33,40", Gender = 1 },
                new TuVi() { Id = 11, StartDate = DateTime.Parse("2000/02/05"), EndDate = DateTime.Parse("2001/01/23"), NegativeAge = "Canh Thìn", FiveElements = "Hỏa", HoroscopeMatch = "31", Gender = 1 },
                new TuVi() { Id = 12, StartDate = DateTime.Parse("2001/01/24"), EndDate = DateTime.Parse("2002/02/11"), NegativeAge = "Tân Tỵ", FiveElements = "Thổ", HoroscopeMatch = "32,38,39", Gender = 1 },
                new TuVi() { Id = 13, StartDate = DateTime.Parse("2002/02/12"), EndDate = DateTime.Parse("2003/01/31"), NegativeAge = "Nhâm Ngọ", FiveElements = "Kim", HoroscopeMatch = "37", Gender = 1 },
                new TuVi() { Id = 14, StartDate = DateTime.Parse("2003/02/14"), EndDate = DateTime.Parse("2004/01/21"), NegativeAge = "Quý Mùi", FiveElements = "Kim", HoroscopeMatch = "34", Gender = 1 },
                new TuVi() { Id = 15, StartDate = DateTime.Parse("2004/01/22"), EndDate = DateTime.Parse("2005/02/08"), NegativeAge = "Giáp Thân", FiveElements = "Thổ", HoroscopeMatch = "36", Gender = 1 },
                new TuVi() { Id = 16, StartDate = DateTime.Parse("2005/02/09"), EndDate = DateTime.Parse("2006/01/28"), NegativeAge = "Ất Dậu", FiveElements = "Mộc", HoroscopeMatch = "35,36", Gender = 1 },
                new TuVi() { Id = 17, StartDate = DateTime.Parse("2006/01/29"), EndDate = DateTime.Parse("2007/02/16"), NegativeAge = "Bính Tuất", FiveElements = "Thổ", HoroscopeMatch = "34", Gender = 1 },
                new TuVi() { Id = 18, StartDate = DateTime.Parse("2007/02/17"), EndDate = DateTime.Parse("2008/02/06"), NegativeAge = "Đinh Hợi", FiveElements = "Thủy", HoroscopeMatch = "32", Gender = 1 },
                new TuVi() { Id = 19, StartDate = DateTime.Parse("2008/02/07"), EndDate = DateTime.Parse("2009/01/25"), NegativeAge = "Mậu Tý", FiveElements = "Hỏa", HoroscopeMatch = "35", Gender = 1 },
                new TuVi() { Id = 20, StartDate = DateTime.Parse("2009/01/26"), EndDate = DateTime.Parse("2010/02/13"), NegativeAge = "Kỷ Sửu", FiveElements = "Thổ", HoroscopeMatch = "38,33", Gender = 1 },
                new TuVi() { Id = 21, StartDate = DateTime.Parse("1990/01/27"), EndDate = DateTime.Parse("1991/02/14"), NegativeAge = "Canh Ngọ", FiveElements = "Thổ", HoroscopeMatch = "5", Gender = 0 },
                new TuVi() { Id = 22, StartDate = DateTime.Parse("1991/02/15"), EndDate = DateTime.Parse("1992/02/02"), NegativeAge = "Tận Mùi", FiveElements = "Kim", HoroscopeMatch = "4", Gender = 0 },
                new TuVi() { Id = 23, StartDate = DateTime.Parse("1992/02/04"), EndDate = DateTime.Parse("1993/01/22"), NegativeAge = "Nhâm Thân", FiveElements = "Kim", HoroscopeMatch = "3", Gender = 0 },
                new TuVi() { Id = 24, StartDate = DateTime.Parse("1993/01/23"), EndDate = DateTime.Parse("1994/02/09"), NegativeAge = "Quý Dậu", FiveElements = "Thổ", HoroscopeMatch = "4,6", Gender = 0 },
                new TuVi() { Id = 25, StartDate = DateTime.Parse("1994/02/10"), EndDate = DateTime.Parse("1995/01/30"), NegativeAge = "Giáp Tuất", FiveElements = "Hỏa", HoroscopeMatch = "3,6", Gender = 0 },
                new TuVi() { Id = 26, StartDate = DateTime.Parse("1995/02/01"), EndDate = DateTime.Parse("1996/02/18"), NegativeAge = "Ất Hợi", FiveElements = "Thủy", HoroscopeMatch = "8", Gender = 0 },
                new TuVi() { Id = 27, StartDate = DateTime.Parse("1996/02/19"), EndDate = DateTime.Parse("1997/02/06"), NegativeAge = "Bính Tý", FiveElements = "Thổ", HoroscopeMatch = "4,7", Gender = 0 },
                new TuVi() { Id = 28, StartDate = DateTime.Parse("1997/02/07"), EndDate = DateTime.Parse("1998/01/27"), NegativeAge = "Đinh Sửu", FiveElements = "Mộc", HoroscopeMatch = "9", Gender = 0 },
                new TuVi() { Id = 29, StartDate = DateTime.Parse("1998/01/28"), EndDate = DateTime.Parse("1999/02/15"), NegativeAge = "Mậu Dần", FiveElements = "Mộc", HoroscopeMatch = "6", Gender = 0 }
                new TuVi() { Id = 30, StartDate = DateTime.Parse("1999/02/16"), EndDate = DateTime.Parse("2000/02/04"), NegativeAge = "Kỷ Mão", FiveElements = "Thổ", HoroscopeMatch = "12", Gender = 0 },
                new TuVi() { Id = 31, StartDate = DateTime.Parse("2000/02/05"), EndDate = DateTime.Parse("2001/01/23"), NegativeAge = "Canh Thìn", FiveElements = "Kim", HoroscopeMatch = "8", Gender = 0 },
                new TuVi() { Id = 32, StartDate = DateTime.Parse("2001/01/24"), EndDate = DateTime.Parse("2002/02/11"), NegativeAge = "Tân Tỵ", FiveElements = "Kim", HoroscopeMatch = "10,12,13", Gender = 0 },
                new TuVi() { Id = 33, StartDate = DateTime.Parse("2002/02/12"), EndDate = DateTime.Parse("2003/01/31"), NegativeAge = "Nhâm Ngọ", FiveElements = "Hỏa", HoroscopeMatch = "11", Gender = 0 },
                new TuVi() { Id = 34, StartDate = DateTime.Parse("2003/02/14"), EndDate = DateTime.Parse("2004/01/21"), NegativeAge = "Quý Mùi", FiveElements = "Thủy", HoroscopeMatch = "10", Gender = 0 },
                new TuVi() { Id = 35, StartDate = DateTime.Parse("2004/01/22"), EndDate = DateTime.Parse("2005/02/08"), NegativeAge = "Giáp Thân", FiveElements = "Thổ", HoroscopeMatch = "13", Gender = 0 },
                new TuVi() { Id = 36, StartDate = DateTime.Parse("2005/02/09"), EndDate = DateTime.Parse("2006/01/28"), NegativeAge = "Ất Dậu", FiveElements = "Mộc",HoroscopeMatch = "7", Gender = 0 },
                new TuVi() { Id = 37, StartDate = DateTime.Parse("2006/01/29"), EndDate = DateTime.Parse("2007/02/16"), NegativeAge = "Bính Tuất", FiveElements = "Mộc", HoroscopeMatch = "18", Gender = 0 },
                new TuVi() { Id = 38, StartDate = DateTime.Parse("2007/02/17"), EndDate = DateTime.Parse("2008/02/06"), NegativeAge = "Đinh Hợi", FiveElements = "Thổ", HoroscopeMatch = "16,12", Gender = 0 },
                new TuVi() { Id = 39, StartDate = DateTime.Parse("2008/02/07"), EndDate = DateTime.Parse("2009/01/25"), NegativeAge = "Mậu Tý", FiveElements = "Kim", HoroscopeMatch = "13,14", Gender = 0 },
                new TuVi() { Id = 40, StartDate = DateTime.Parse("2009/01/26"), EndDate = DateTime.Parse("2010/02/13"), NegativeAge = "Kỷ Sửu", FiveElements = "Kim", HoroscopeMatch = "17", Gender = 0 }
            );
            context.Users.AddOrUpdate(x => x.Id,
                new ApplicationUser() { Id = "1", UserName = "mai1", EmailConfirmed = false, PhoneNumberConfirmed = false, TwoFactorEnabled = false, LockoutEnabled = true, AccessFailedCount = 0, FullName = "MaiNe", Gender = 1, BirthDay = DateTime.Parse("1992/05/12"), Avatar = "", Address = "Hà Nội", Character = ApplicationUser.CharacterType.Funny },
                new ApplicationUser() { Id = "2", UserName = "mai2", EmailConfirmed = false, PhoneNumberConfirmed = false, TwoFactorEnabled = false, LockoutEnabled = true, AccessFailedCount = 0, FullName = "MaiNe", Gender = 0, BirthDay = DateTime.Parse("1998/02/10"), Avatar = "", Address = "Hà Nội", Character = ApplicationUser.CharacterType.Funny }


                );
        }
    }
}
