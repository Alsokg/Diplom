namespace StudentMonitoringSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DataMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "StydentBookNumber", c => c.String());
            AddColumn("dbo.AspNetUsers", "isLector", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "isLector");
            DropColumn("dbo.AspNetUsers", "StydentBookNumber");
        }
    }
}
