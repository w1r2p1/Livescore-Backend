namespace LivescoreRest.DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GameIncidentResult : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.GameIncidents", "Result", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.GameIncidents", "Result");
        }
    }
}
