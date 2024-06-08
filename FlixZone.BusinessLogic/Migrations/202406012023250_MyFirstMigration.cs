namespace FlixZone.BusinessLogic.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MyFirstMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AnimeLists",
                c => new
                    {
                        Anime_Id = c.Int(nullable: false, identity: true),
                        Anime_Name = c.String(nullable: false),
                        Anime_Author = c.String(nullable: false),
                        Anime_Description = c.String(nullable: false),
                        Anime_Type = c.String(nullable: false),
                        Anime_Studios = c.String(),
                        Anime_Date = c.String(),
                        Anime_Status = c.String(),
                        Anime_Genre = c.String(nullable: false),
                        Anime_Views = c.Int(nullable: false),
                        Anime_Comment = c.Int(nullable: false),
                        Anime_Image = c.String(nullable: false),
                        Anime_Video = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Anime_Id);
            
            CreateTable(
                "dbo.Sessions",
                c => new
                    {
                        SessionId = c.Int(nullable: false, identity: true),
                        Username = c.String(nullable: false, maxLength: 30),
                        CookieString = c.String(nullable: false),
                        ExpireTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.SessionId);
            
            CreateTable(
                "dbo.UserLogins",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Username = c.String(nullable: false, maxLength: 30),
                        Password = c.String(nullable: false, maxLength: 50),
                        Email = c.String(nullable: false, maxLength: 30),
                        LastLogin = c.DateTime(nullable: false),
                        LasIp = c.String(maxLength: 30),
                        Level = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.UserLogins");
            DropTable("dbo.Sessions");
            DropTable("dbo.AnimeLists");
        }
    }
}
