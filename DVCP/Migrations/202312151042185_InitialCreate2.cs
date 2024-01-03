namespace DVCP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Posts", "ArticleDes", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Posts", "ArticleDes");
        }
    }
}
