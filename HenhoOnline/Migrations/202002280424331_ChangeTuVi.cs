namespace HenhoOnline.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeTuVi : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.TuVis", "StartDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.TuVis", "EndDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.TuVis", "EndDate", c => c.String());
            AlterColumn("dbo.TuVis", "StartDate", c => c.String());
        }
    }
}
