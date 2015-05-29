namespace LivescoreRest.DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GameIncidents : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.GameIncidents",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MatchTime = c.String(nullable: false),
                        Comment = c.String(),
                        GameId = c.Int(nullable: false),
                        PlayerId = c.Int(),
                        MatchIncidentType = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Games", t => t.GameId, cascadeDelete: true)
                .ForeignKey("dbo.Players", t => t.PlayerId)
                .Index(t => t.GameId)
                .Index(t => t.PlayerId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.GameIncidents", "PlayerId", "dbo.Players");
            DropForeignKey("dbo.GameIncidents", "GameId", "dbo.Games");
            DropIndex("dbo.GameIncidents", new[] { "PlayerId" });
            DropIndex("dbo.GameIncidents", new[] { "GameId" });
            DropTable("dbo.GameIncidents");
        }
    }
}
