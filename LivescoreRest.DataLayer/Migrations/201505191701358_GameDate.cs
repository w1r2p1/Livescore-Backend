namespace LivescoreRest.DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GameDate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Games", "MatchDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Games", "MatchDate");
        }
    }
}
