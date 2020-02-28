namespace HenhoOnline.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeUser : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AspNetUsers", "HoroscopeId", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.AspNetUsers", "HoroscopeId", c => c.Int(nullable: false));
        }
    }
}
