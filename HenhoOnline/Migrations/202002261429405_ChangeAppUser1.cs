namespace HenhoOnline.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeAppUser1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TuVis",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        Tuoi = c.String(),
                        Menh = c.String(),
                        TuoiHop = c.String(),
                        Gender = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AlterColumn("dbo.AspNetUsers", "Character", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.AspNetUsers", "Character", c => c.Int(nullable: false));
            DropTable("dbo.TuVis");
        }
    }
}
