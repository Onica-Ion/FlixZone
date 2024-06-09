namespace FlixZone.BusinessLogic.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class myMigration : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Comments", "Anime_Id");
            CreateIndex("dbo.Reviews", "Anime_Id");
            AddForeignKey("dbo.Comments", "Anime_Id", "dbo.AnimeLists", "Anime_Id", cascadeDelete: true);
            AddForeignKey("dbo.Reviews", "Anime_Id", "dbo.AnimeLists", "Anime_Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reviews", "Anime_Id", "dbo.AnimeLists");
            DropForeignKey("dbo.Comments", "Anime_Id", "dbo.AnimeLists");
            DropIndex("dbo.Reviews", new[] { "Anime_Id" });
            DropIndex("dbo.Comments", new[] { "Anime_Id" });
        }
    }
}
