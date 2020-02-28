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
            context.Database.ExecuteSqlCommand("DBCC CHECKIDENT('dbo.Horoscopes', RESEED, 0)");
            context.Horoscopes.AddOrUpdate(x => x.Id,
                //new TuVi() { Id = 1, StartDate = "27/01/1990", EndDate = "14/02/1991", Tuoi = "Canh Ngọ", Menh = "Thủy", TuoiHop = "Tân Mùi, Giáp Tuất, Đinh Sửu, Mậu Thìn", TuViHop = "8,9" , Gender = 1 },
                //new TuVi() { Id = 2, StartDate = "15/02/1991", EndDate = "03/02/1992", Tuoi = "Tận Mùi", Menh = "Hỏa", TuoiHop = "Quý Dậu, Ất Hợi, Bính Tý, Kỷ Mão, Kỷ Tỵ, Canh Ngọ", TuViHop = "1,4,7" , Gender = 1 },
                new Horoscope() { Id = 1, StartDate = DateTime.Parse("1992/02/04"), EndDate = DateTime.Parse("1993/01/22"), NegativeAge = "Nhâm Thân", FiveElements = "Thổ", HoroscopeMatch = "2", Gender = 1 },
                //new TuVi() { Id = 4, StartDate = "23/01/1993", EndDate = "09/02/1994", Tuoi = "Quý Dậu", Menh = "Kim", TuoiHop = "Quý Dậu, Ất Hợi, Đinh Sửu, Kỷ Mão, Tân Tỵ", TuViHop = "4,6,10" , Gender = 1 },
                //new TuVi() { Id = 5, StartDate = "10/02/1994", EndDate = "30/01/1995", Tuoi = "Giáp Tuất", Menh = "Kim", TuoiHop = "Ất Hợi, Bính Tý, Mậu Dần, Tân Tỵ, Nhâm Ngọ, Nhâm Thân", TuViHop = "7,9,13" , Gender = 1 },
                //new TuVi() { Id = 6, StartDate = "01/02/1995", EndDate = "18/02/1996", Tuoi = "Ất Hợi", Menh = "Thổ", TuoiHop = "Đinh Sửu, Canh Thìn, Quý Mùi, Giáp Tuất", TuViHop = "8,5" , Gender = 1 },
                //new TuVi() { Id = 7, StartDate = "19/02/1996", EndDate = "06/02/1997", Tuoi = "Bính Tý", Menh = "Mộc", TuoiHop = "Bính Tý, Tân Tỵ, Nhâm Ngọ, Ất Dậu", TuViHop = "7,16" , Gender = 1 },
                //new TuVi() { Id = 8, StartDate = "07/02/1997", EndDate = "27/01/1998", Tuoi = "Đinh Sửu", Menh = "Mộc", TuoiHop = "Canh Dần, Quý Tỵ, Giáp Ngọ, Bính Thân, Mậu Tý, Đinh Hợi", TuViHop = "18" , Gender = 1 },
                //new TuVi() { Id = 9, StartDate = "28/01/1998", EndDate = "15/02/1999", Tuoi = "Mậu Dần", Menh = "Thổ", TuoiHop = "Nhâm Thìn, Ất Mùi, Mật Tuất, Kỷ Sửu", TuViHop = "20" , Gender = 1 },
                //new TuVi() { Id = 10, StartDate = "16/02/1999", EndDate = "04/02/2000", Tuoi = "Kỷ Mão", Menh = "Thủy", TuoiHop = "Tân Tỵ, Nhâm Ngọ, Giáp Thân, Đinh Hợi, Mậu Dần", TuViHop = "9,12,13,20" , Gender = 1 },
                //new TuVi() { Id = 11, StartDate = "05/02/2000", EndDate = "23/01/2001", Tuoi = "Canh Thìn", Menh = "Hỏa", TuoiHop = "Canh Thìn, Bính Tuất, Kỷ Sửu, Đinh Sửu", TuViHop = "11" ,Gender = 1 },
                //new TuVi() { Id = 12, StartDate = "24/01/2001", EndDate = "11/02/2002", Tuoi = "Tân Tỵ", Menh = "Thổ", TuoiHop = "Tân Tỵ, Nhâm Ngọ, Ất Dậu, Đinh Hợi, Mậu Tý, Kỷ Mão", TuViHop = "12,18,19" , Gender = 1 },
                //new TuVi() { Id = 13, StartDate = "12/02/2002", EndDate = "31/01/2003", Tuoi = "Nhâm Ngọ", Menh = "Kim", TuoiHop = "Giáp Thân, Bính Tuất, Canh Dần, Canh Thìn", TuViHop = "17" , Gender = 1 },
                //new TuVi() { Id = 14, StartDate = "14/02/2003", EndDate = "21/01/2004", Tuoi = "Quý Mùi", Menh = "Kim", TuoiHop = "Quý Mùi, Ất Mùi, Đinh Hợi, Kỷ Sửu, Tân Mão, Tân Tỵ, Kỷ Mão", TuViHop = "14" , Gender = 1 },
                //new TuVi() { Id = 15, StartDate = "22/01/2004", EndDate = "08/02/2005", Tuoi = "Giáp Thân", Menh = "Thổ", TuoiHop = "Nhâm Tuất, Ất Sửu, Mậu Thìn, Kỷ Mùi", TuViHop = "16" , Gender = 1 },
                //new TuVi() { Id = 16, StartDate = "09/02/2005", EndDate = "28/01/2006", Tuoi = "Ất Dậu", Menh = "Mộc", TuoiHop = "Bính Tuất, Kỷ Sửu, Nhâm Thìn, Quý Mùi", Gender = 1 },
                //new TuVi() { Id = 17, StartDate = "29/01/2006", EndDate = "16/02/2007", Tuoi = "Bính Tuất", Menh = "Thổ", TuoiHop = "Đinh Hợi, Mậu Tý, Tân Mão, Quý Tỵ, Giáp Ngọ, Ất Dậu", Gender = 1 },
                //new TuVi() { Id = 18, StartDate = "17/02/2007", EndDate = "06/02/2008", Tuoi = "Đinh Hợi", Menh = "Thủy", TuoiHop = "Canh Dần, Nhâm Thìn, Bính Tuất", Gender = 1 },
                //new TuVi() { Id = 19, StartDate = "07/02/2008", EndDate = "25/01/2009", Tuoi = "Mậu Tý", Menh = "Hỏa", TuoiHop = "Kỷ Sửu, Đinh Dậu, Đinh Hợi, Ất Mùi", Gender = 1 },
                //new TuVi() { Id = 20, StartDate = "26/01/2009", EndDate = "13/02/2010", Tuoi = "Kỷ Sửu", Menh = "Thổ", TuoiHop = "Canh Dần, Quý Tỵ, Giáp Ngọ, Bính Thân, Mậu Tý, Đinh Hợi", Gender = 1 },
                //new TuVi() { Id = 21, StartDate = "27/01/1990", EndDate = "14/02/1991", Tuoi = "Canh Ngọ", Menh = "Thổ", TuoiHop = "Tân Mùi, Giáp Tuất, Đinh Sửu, Mậu Thìn", TuViHop = "5" , Gender = 0 },
                //new TuVi() { Id = 22, StartDate = "15/02/1991", EndDate = "03/02/1992", Tuoi = "Tận Mùi", Menh = "Kim", TuoiHop = "Quý Dậu, Ất Hợi, Bính Tý, Kỷ Mão, Canh Ngọ, Kỷ Tỵ", TuViHop = "4" , Gender = 0 },
                //new TuVi() { Id = 23, StartDate = "03/02/1992", EndDate = "22/01/1993", Tuoi = "Nhâm Thân", Menh = "Kim", TuoiHop = "Nhâm Thân, Giáp Tuất, Mậu Dần, Canh Thìn", TuViHop = "3" , Gender = 0 },
                //new TuVi() { Id = 24, StartDate = "23/01/1993", EndDate = "09/02/1994", Tuoi = "Quý Dậu", Menh = "Thổ", TuoiHop = "Quý Dậu, Ất Hợi, Đinh Sửu, Kỷ Mão, Tân Kỵ và Tân Mùi", TuViHop = "4,6" , Gender = 0 },
                //new TuVi() { Id = 25, StartDate = "10/02/1994", EndDate = "30/01/1995", Tuoi = "Giáp Tuất", Menh = "Hỏa", TuoiHop = "Ất Hợi, Bính Tý, Mậu Dần, Tân Tỵ, Nhâm Ngọ, Nhâm Thân", TuViHop = "3,6" , Gender = 0 },
                //new TuVi() { Id = 26, StartDate = "01/02/1995", EndDate = "18/02/1996", Tuoi = "Ất Hợi", Menh = "Thủy", TuoiHop = "Đinh Sửu, Canh Thìn, Quý Mùi, Giáp Tuất", TuViHop = "8" ,Gender = 0 },
                //new TuVi() { Id = 27, StartDate = "19/02/1996", EndDate = "06/02/1997", Tuoi = "Bính Tý", Menh = "Thổ", TuoiHop = "Bính Tý , Tân Tỵ, Nhâm Ngọ, Ất Dậu, Ất Hợi, Quý Dậu", TuViHop = "4,7" , Gender = 0 },
                //new TuVi() { Id = 28, StartDate = "07/02/1997", EndDate = "27/01/1998", Tuoi = "Đinh Sửu", Menh = "Mộc", TuoiHop = "Mậu Dần, Canh Thìn, Giáp Thân", TuViHop = "9" , Gender = 0 },
                new Horoscope() { Id = 2, StartDate = DateTime.Parse("1998/01/28"), EndDate = DateTime.Parse("1999/02/15"), NegativeAge = "Mậu Dần", FiveElements = "Mộc", HoroscopeMatch = "6", Gender = 0 }
                //new TuVi() { Id = 30, StartDate = "16/02/1999", EndDate = "04/02/2000", Tuoi = "Kỷ Mão", Menh = "Thổ", TuoiHop = "Tân Tỵ, Nhâm Ngọ, Giáp Thân, Đinh Hợi, Mậu Dần", TuViHop = "12" , Gender = 0 },
                //new TuVi() { Id = 31, StartDate = "05/02/2000", EndDate = "23/01/2001", Tuoi = "Canh Thìn", Menh = "Kim", TuoiHop = "Canh Thìn, Bính Tuất, Kỷ Sửu, Đinh Sửu", TuViHop = "8" , Gender = 0 },
                //new TuVi() { Id = 32, StartDate = "24/01/2001", EndDate = "11/02/2002", Tuoi = "Tân Tỵ", Menh = "Kim", TuoiHop = "Tân Tỵ, Nhâm Ngọ, Ất Dậu, Đinh Hợi, Mậu Tý, Kỷ Mão", TuViHop = "10,12,13" , Gender = 0 },
                //new TuVi() { Id = 33, StartDate = "12/02/2002", EndDate = "31/01/2003", Tuoi = "Nhâm Ngọ", Menh = "Hỏa", TuoiHop = "Giáp Thân, Bính Tuất, Canh Dần, Canh Thìn", TuViHop = "11", Gender = 0 },
                //new TuVi() { Id = 34, StartDate = "14/02/2003", EndDate = "21/01/2004", Tuoi = "Quý Mùi", Menh = "Thủy", TuoiHop = "Quý Mùi, Ất Dậu, Đinh Hợi, Kỷ Sửu, Tân Mão, Tân Tỵ, Kỷ Mão", TuViHop = "10" , Gender = 0 },
                //new TuVi() { Id = 35, StartDate = "22/01/2004", EndDate = "08/02/2005", Tuoi = "Giáp Thân", Menh = "Thổ", TuoiHop = "Giáp Thân, Mậu Tý, Canh Dần, Quý Tỵ, Nhâm Ngọ, Tân Tỵ", TuViHop = "13" , Gender = 0 },
                //new TuVi() { Id = 36, StartDate = "09/02/2005", EndDate = "28/01/2006", Tuoi = "Ất Dậu", Menh = "Mộc", TuoiHop = "Bính Tuất, Kỷ Sửu, Nhâm Thìn và Quý Mùi", Gender = 0 },
                //new TuVi() { Id = 37, StartDate = "29/01/2006", EndDate = "16/02/2007", Tuoi = "Bính Tuất", Menh = "Mộc", TuoiHop = "Đinh Hợi, Mậu Tý, Tân Mão, Quý Tỵ, Giáp Ngọ, Ất Dậu", Gender = 0 },
                //new TuVi() { Id = 38, StartDate = "17/02/2007", EndDate = "06/02/2008", Tuoi = "Đinh Hợi", Menh = "Thổ", TuoiHop = "Canh Dần, Nhâm Thìn, Bính Tuất", Gender = 0 },
                //new TuVi() { Id = 39, StartDate = "07/02/2008", EndDate = "25/01/2009", Tuoi = "Mậu Tý", Menh = "Kim", TuoiHop = "Kỷ Sửu, Quí Tỵ, Ất Mùi, Đinh Dậu, Đinh Hợi, Ất Dậu", Gender = 0 },
                //new TuVi() { Id = 40, StartDate = "26/01/2009", EndDate = "13/02/2010", Tuoi = "Kỷ Sửu", Menh = "Kim", TuoiHop = "Canh Dần, Quý Tỵ, Giáp Ngọ, Bính Thân, Mậu Tý, Đinh Hợi", Gender = 0 }
            );
            //context.Users.AddOrUpdate(x => x.Id,
            //    new ApplicationUser() { Id = "1", UserName = "mai1", EmailConfirmed = false, PhoneNumberConfirmed = false, TwoFactorEnabled = false, LockoutEnabled = true, AccessFailedCount = 0, FullName = "MaiNe", Gender = 1, BirthDay = DateTime.Parse("1992/05/12"), Avatar = "", Address = "Hà Nội", Character = ApplicationUser.CharacterType.Funny },
            //    new ApplicationUser() { Id = "2", UserName = "mai2", EmailConfirmed = false, PhoneNumberConfirmed = false, TwoFactorEnabled = false, LockoutEnabled = true, AccessFailedCount = 0, FullName = "MaiNe", Gender = 0, BirthDay = DateTime.Parse("1998/02/10"), Avatar = "", Address = "Hà Nội", Character = ApplicationUser.CharacterType.Funny }


            //    );
        }
    }
}
