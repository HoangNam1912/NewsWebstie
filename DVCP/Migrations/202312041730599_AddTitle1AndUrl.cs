namespace DVCP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTitle1AndUrl : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Posts", "Title1", c => c.String());
            AddColumn("dbo.Posts", "Url", c => c.String());
            AddColumn("dbo.Posts", "img", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Posts", "img");
            DropColumn("dbo.Posts", "Url");
            DropColumn("dbo.Posts", "Title1");
        }
    }
}
