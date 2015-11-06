namespace CalendarWebApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTitle : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Events", "title", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Events", "title");
        }
    }
}
