namespace MotoTour.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newmigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Posts", "StartLocation", c => c.String());
            AddColumn("dbo.Posts", "EndLocation", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Posts", "EndLocation");
            DropColumn("dbo.Posts", "StartLocation");
        }
    }
}
