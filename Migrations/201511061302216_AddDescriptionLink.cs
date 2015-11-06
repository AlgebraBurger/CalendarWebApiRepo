namespace CalendarWebApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDescriptionLink : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Events", "description", c => c.String());
            AddColumn("dbo.Events", "link", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Events", "link");
            DropColumn("dbo.Events", "description");
        }
    }
}
