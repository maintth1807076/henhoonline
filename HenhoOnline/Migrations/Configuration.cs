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
            ContextKey = "HenhoOnline.Models.ApplicationDbContext";
        }

        protected override void Seed(HenhoOnline.Models.ApplicationDbContext context)
        {
            context.TuVis.AddOrUpdate(x => x.Id,
                new TuVi() { Id = 1, StartDate = "27/01/1990", EndDate = "14/02/1991", Tuoi = "Canh Ngọ", Menh = "Thủy", TuoiHop = "Tân Mùi, Giáp Tuất, Đinh Sửu, Mậu Thìn", Gender = 1 },
                new TuVi() { Id = 2, StartDate = "15/02/1991", EndDate = "03/02/1992", Tuoi = "Tận Mùi", Menh = "Hỏa", TuoiHop = "Quý Dậu, Ất Hợi, Bính Tý, Kỷ Mão, Kỷ Tỵ, Canh Ngọ", Gender = 1 },
                new TuVi() { Id = 3, StartDate = "03/02/1992", EndDate = "22/01/1993", Tuoi = "Nhâm Thân", Menh = "Thổ", TuoiHop = "Canh Thân, Mậu Dần, Canh Thìn", Gender = 1 },
                new TuVi() { Id = 4, StartDate = "23/01/1993", EndDate = "09/02/1994", Tuoi = "Quý Dậu", Menh = "Kim", TuoiHop = "Quý Dậu, Ất Hợi, Đinh Sửu, Kỷ Mão, Tân Tỵ", Gender = 1 },
                new TuVi() { Id = 5, StartDate = "10/02/1994", EndDate = "30/01/1995", Tuoi = "Giáp Tuất", Menh = "Kim", TuoiHop = "Ất Hợi, Bính Tý, Mậu Dần, Tân Tỵ, Nhâm Ngọ, Nhâm Thân", Gender = 1 },
                new TuVi() { Id = 6, StartDate = "01/02/1995", EndDate = "18/02/1996", Tuoi = "Ất Hợi", Menh = "Thổ", TuoiHop = "Đinh Sửu, Canh Thìn, Quý Mùi, Giáp Tuất", Gender = 1 },
                new TuVi() { Id = 7, StartDate = "19/02/1996", EndDate = "06/02/1997", Tuoi = "Bính Tý", Menh = "Mộc", TuoiHop = "Bính Tý, Tân Tỵ, Nhâm Ngọ, Ất Dậu", Gender = 1 },
                new TuVi() { Id = 8, StartDate = "07/02/1997", EndDate = "27/01/1998", Tuoi = "Đinh Sửu", Menh = "Mộc", TuoiHop = "Canh Dần, Quý Tỵ, Giáp Ngọ, Bính Thân, Mậu Tý, Đinh Hợi", Gender = 1 },
                new TuVi() { Id = 9, StartDate = "28/01/1998", EndDate = "15/02/1999", Tuoi = "Mậu Dần", Menh = "Thổ", TuoiHop = "Nhâm Thìn, Ất Mùi, Mật Tuất, Kỷ Sửu", Gender = 1 },
                new TuVi() { Id = 10, StartDate = "16/02/1999", EndDate = "04/02/2000", Tuoi = "Kỷ Mão", Menh = "Thủy", TuoiHop = "Tân Tỵ, Nhâm Ngọ, Giáp Thân, Đinh Hợi, Mậu Dần", Gender = 1 },
                new TuVi() { Id = 11, StartDate = "05/02/2000", EndDate = "23/01/2001", Tuoi = "Canh Thìn", Menh = "Hỏa", TuoiHop = "Canh Thìn, Bính Tuất, Kỷ Sửu, Đinh Sửu", Gender = 1 },
                new TuVi() { Id = 12, StartDate = "24/01/2001", EndDate = "11/02/2002", Tuoi = "Tân Tỵ", Menh = "Thổ", TuoiHop = "Tân Tỵ, Nhâm Ngọ, Ất Dậu, Đinh Hợi, Mậu Tý, Kỷ Mão", Gender = 1 },
                new TuVi() { Id = 13, StartDate = "12/02/2002", EndDate = "31/01/2003", Tuoi = "Nhâm Ngọ", Menh = "Kim", TuoiHop = "Giáp Thân, Bính Tuất, Canh Dần, Canh Thìn", Gender = 1 },
                new TuVi() { Id = 14, StartDate = "14/02/2003", EndDate = "21/01/2004", Tuoi = "Quý Mùi", Menh = "Kim", TuoiHop = "Quý Mùi, Ất Mùi, Đinh Hợi, Kỷ Sửu, Tân Mão, Tân Tỵ, Kỷ Mão", Gender = 1 },
                new TuVi() { Id = 15, StartDate = "22/01/2004", EndDate = "08/02/2005", Tuoi = "Giáp Thân", Menh = "Thổ", TuoiHop = "Nhâm Tuất, Ất Sửu, Mậu Thìn, Kỷ Mùi", Gender = 1 },
                new TuVi() { Id = 16, StartDate = "09/02/2005", EndDate = "28/01/2006", Tuoi = "Ất Dậu", Menh = "Mộc", TuoiHop = "Bính Tuất, Kỷ Sửu, Nhâm Thìn, Quý Mùi", Gender = 1 },
                new TuVi() { Id = 17, StartDate = "29/01/2006", EndDate = "16/02/2007", Tuoi = "Bính Tuất", Menh = "Thổ", TuoiHop = "Đinh Hợi, Mậu Tý, Tân Mão, Quý Tỵ, Giáp Ngọ, Ất Dậu", Gender = 1 },
                new TuVi() { Id = 18, StartDate = "17/02/2007", EndDate = "06/02/2008", Tuoi = "Đinh Hợi", Menh = "Thủy", TuoiHop = "Canh Dần, Nhâm Thìn, Bính Tuất", Gender = 1 },
                new TuVi() { Id = 19, StartDate = "07/02/2008", EndDate = "25/01/2009", Tuoi = "Mậu Tý", Menh = "Hỏa", TuoiHop = "Kỷ Sửu, Đinh Dậu, Đinh Hợi, Ất Mùi", Gender = 1 },
                new TuVi() { Id = 20, StartDate = "26/01/2009", EndDate = "13/02/2010", Tuoi = "Kỷ Sửu", Menh = "Thổ", TuoiHop = "Canh Dần, Quý Tỵ, Giáp Ngọ, Bính Thân, Mậu Tý, Đinh Hợi", Gender = 1 },
                new TuVi() { Id = 21, StartDate = "27/01/1990", EndDate = "14/02/1991", Tuoi = "Canh Ngọ", Menh = "Thổ", TuoiHop = "Tân Mùi, Giáp Tuất, Đinh Sửu, Mậu Thìn", Gender = 0 },
                new TuVi() { Id = 22, StartDate = "15/02/1991", EndDate = "03/02/1992", Tuoi = "Tận Mùi", Menh = "Kim", TuoiHop = "Quý Dậu, Ất Hợi, Bính Tý, Kỷ Mão, Canh Ngọ, Kỷ Tỵ", Gender = 0 },
                new TuVi() { Id = 23, StartDate = "03/02/1992", EndDate = "22/01/1993", Tuoi = "Nhâm Thân", Menh = "Kim", TuoiHop = "Nhâm Thân, Giáp Tuất, Mậu Dần, Canh Thìn", Gender = 0 },
                new TuVi() { Id = 24, StartDate = "23/01/1993", EndDate = "09/02/1994", Tuoi = "Quý Dậu", Menh = "Thổ", TuoiHop = "Quý Dậu, Ất Hợi, Đinh Sửu, Kỷ Mão, Tân Kỵ và Tân Mùi", Gender = 0 },
                new TuVi() { Id = 25, StartDate = "10/02/1994", EndDate = "30/01/1995", Tuoi = "Giáp Tuất", Menh = "Hỏa", TuoiHop = "Ất Hợi, Bính Tý, Mậu Dần, Tân Tỵ, Nhâm Ngọ, Nhâm Thân", Gender = 0 },
                new TuVi() { Id = 26, StartDate = "01/02/1995", EndDate = "18/02/1996", Tuoi = "Ất Hợi", Menh = "Thủy", TuoiHop = "Đinh Sửu, Canh Thìn, Quý Mùi, Giáp Tuất", Gender = 0 },
                new TuVi() { Id = 27, StartDate = "19/02/1996", EndDate = "06/02/1997", Tuoi = "Bính Tý", Menh = "Thổ", TuoiHop = "Bính Tý , Tân Tỵ, Nhâm Ngọ, Ất Dậu, Ất Hợi, Quý Dậu", Gender = 0 },
                new TuVi() { Id = 28, StartDate = "07/02/1997", EndDate = "27/01/1998", Tuoi = "Đinh Sửu", Menh = "Mộc", TuoiHop = "Mậu Dần, Canh Thìn, Giáp Thân", Gender = 0 },
                new TuVi() { Id = 29, StartDate = "28/01/1998", EndDate = "15/02/1999", Tuoi = "Mậu Dần", Menh = "Mộc", TuoiHop = "Kỷ Mão, Quý Mùi, Ất Dậu, Đinh Hợi, Đinh Sửu, Ất Hợi", Gender = 0 },
                new TuVi() { Id = 30, StartDate = "16/02/1999", EndDate = "04/02/2000", Tuoi = "Kỷ Mão", Menh = "Thổ", TuoiHop = "Tân Tỵ, Nhâm Ngọ, Giáp Thân, Đinh Hợi, Mậu Dần", Gender = 0 },
                new TuVi() { Id = 31, StartDate = "05/02/2000", EndDate = "23/01/2001", Tuoi = "Canh Thìn", Menh = "Kim", TuoiHop = "Canh Thìn, Bính Tuất, Kỷ Sửu, Đinh Sửu", Gender = 0 },
                new TuVi() { Id = 32, StartDate = "24/01/2001", EndDate = "11/02/2002", Tuoi = "Tân Tỵ", Menh = "Kim", TuoiHop = "Tân Tỵ, Nhâm Ngọ, Ất Dậu, Đinh Hợi, Mậu Tý, Kỷ Mão", Gender = 0 },
                new TuVi() { Id = 33, StartDate = "12/02/2002", EndDate = "31/01/2003", Tuoi = "Nhâm Ngọ", Menh = "Hỏa", TuoiHop = "Giáp Thân, Bính Tuất, Canh Dần, Canh Thìn", Gender = 0 },
                new TuVi() { Id = 34, StartDate = "14/02/2003", EndDate = "21/01/2004", Tuoi = "Quý Mùi", Menh = "Thủy", TuoiHop = "Quý Mùi, Ất Dậu, Đinh Hợi, Kỷ Sửu, Tân Mão, Tân Tỵ, Kỷ Mão", Gender = 0 },
                new TuVi() { Id = 35, StartDate = "22/01/2004", EndDate = "08/02/2005", Tuoi = "Giáp Thân", Menh = "Thổ", TuoiHop = "Giáp Thân, Mậu Tý, Canh Dần, Quý Tỵ, Nhâm Ngọ, Tân Tỵ", Gender = 0 },
                new TuVi() { Id = 36, StartDate = "09/02/2005", EndDate = "28/01/2006", Tuoi = "Ất Dậu", Menh = "Mộc", TuoiHop = "Bính Tuất, Kỷ Sửu, Nhâm Thìn và Quý Mùi", Gender = 0 },
                new TuVi() { Id = 37, StartDate = "29/01/2006", EndDate = "16/02/2007", Tuoi = "Bính Tuất", Menh = "Mộc", TuoiHop = "Đinh Hợi, Mậu Tý, Tân Mão, Quý Tỵ, Giáp Ngọ, Ất Dậu", Gender = 0 },
                new TuVi() { Id = 38, StartDate = "17/02/2007", EndDate = "06/02/2008", Tuoi = "Đinh Hợi", Menh = "Thổ", TuoiHop = "Canh Dần, Nhâm Thìn, Bính Tuất", Gender = 0 },
                new TuVi() { Id = 39, StartDate = "07/02/2008", EndDate = "25/01/2009", Tuoi = "Mậu Tý", Menh = "Kim", TuoiHop = "Kỷ Sửu, Quí Tỵ, Ất Mùi, Đinh Dậu, Đinh Hợi, Ất Dậu", Gender = 0 },
                new TuVi() { Id = 40, StartDate = "26/01/2009", EndDate = "13/02/2010", Tuoi = "Kỷ Sửu", Menh = "Kim", TuoiHop = "Canh Dần, Quý Tỵ, Giáp Ngọ, Bính Thân, Mậu Tý, Đinh Hợi", Gender = 0 },
            );
            //context.Users.AddOrUpdate(x => x.Id,
            //    new ApplicationUser() { },
            //    new ApplicationUser() { Id = "1", UserName = "", FullName = "", Gender = 1, BirthDay = DateTime.Parse("05/12/1999"), Avatar = "", Address = "", Character = ApplicationUser.CharacterType.Funny}
            //    );
        }
    }
}
