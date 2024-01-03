namespace DVCP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTitleAndImgProperties : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Posts", "titlepp", c => c.String());
            AddColumn("dbo.Posts", "imgpp", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Posts", "imgpp");
            DropColumn("dbo.Posts", "titlepp");
        }
    }
}
