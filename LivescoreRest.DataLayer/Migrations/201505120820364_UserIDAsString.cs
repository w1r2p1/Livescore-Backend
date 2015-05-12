namespace LivescoreRest.DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserIDAsString : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Teams", "UserID", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Teams", "UserID");
        }
    }
}
