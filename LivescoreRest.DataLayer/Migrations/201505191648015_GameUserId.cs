namespace LivescoreRest.DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GameUserId : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Games", "UserId", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Games", "UserId");
        }
    }
}
