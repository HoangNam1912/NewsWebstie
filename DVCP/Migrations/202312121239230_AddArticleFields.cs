namespace DVCP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddArticleFields : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Posts", "ArticleTitle", c => c.String());
            AddColumn("dbo.Posts", "ArticleContent", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Posts", "ArticleContent");
            DropColumn("dbo.Posts", "ArticleTitle");
        }
    }
}
