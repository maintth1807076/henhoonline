namespace HenhoOnline.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedDemoUser : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.TuVis", "StartDate", c => c.String());
            AlterColumn("dbo.TuVis", "EndDate", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.TuVis", "EndDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.TuVis", "StartDate", c => c.DateTime(nullable: false));
        }
    }
}
