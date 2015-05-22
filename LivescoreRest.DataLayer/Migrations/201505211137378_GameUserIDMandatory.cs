namespace LivescoreRest.DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GameUserIDMandatory : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Games", "UserId", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Games", "UserId", c => c.String());
        }
    }
}
