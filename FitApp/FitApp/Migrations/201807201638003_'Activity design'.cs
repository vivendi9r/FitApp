namespace FitApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Activitydesign : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Activities");
            AddColumn("dbo.Activities", "ActivityID", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.Activities", "RoomID", c => c.Int(nullable: false));
            AddColumn("dbo.Activities", "CoachID", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Activities", "ActivityID");
            DropColumn("dbo.Activities", "Id");
            DropColumn("dbo.Activities", "Room");
            DropColumn("dbo.Activities", "Coach");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Activities", "Coach", c => c.String());
            AddColumn("dbo.Activities", "Room", c => c.String());
            AddColumn("dbo.Activities", "Id", c => c.Int(nullable: false, identity: true));
            DropPrimaryKey("dbo.Activities");
            DropColumn("dbo.Activities", "CoachID");
            DropColumn("dbo.Activities", "RoomID");
            DropColumn("dbo.Activities", "ActivityID");
            AddPrimaryKey("dbo.Activities", "Id");
        }
    }
}
