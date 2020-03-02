namespace HenhoOnline.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateHoroscope : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Horoscopes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        NegativeAge = c.String(),
                        FiveElements = c.String(),
                        Gender = c.Int(nullable: false),
                        HoroscopeMatch = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.AspNetUsers", "HoroscopeId", c => c.Int());
            DropTable("dbo.TuVis");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.TuVis",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StartDate = c.String(),
                        EndDate = c.String(),
                        Tuoi = c.String(),
                        Menh = c.String(),
                        TuoiHop = c.String(),
                        Gender = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            DropColumn("dbo.AspNetUsers", "HoroscopeId");
            DropTable("dbo.Horoscopes");
        }
    }
}
