namespace GameTicTacToe.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial_create : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Games",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Player_Id = c.Int(),
                        FirstPlayer_Id = c.Int(),
                        SecondPlayer_Id = c.Int(),
                        Winner_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Players", t => t.Player_Id)
                .ForeignKey("dbo.Players", t => t.FirstPlayer_Id)
                .ForeignKey("dbo.Players", t => t.SecondPlayer_Id)
                .ForeignKey("dbo.Players", t => t.Winner_Id)
                .Index(t => t.Player_Id)
                .Index(t => t.FirstPlayer_Id)
                .Index(t => t.SecondPlayer_Id)
                .Index(t => t.Winner_Id);
            
            CreateTable(
                "dbo.Players",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nick = c.String(),
                        Score = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Games", "Winner_Id", "dbo.Players");
            DropForeignKey("dbo.Games", "SecondPlayer_Id", "dbo.Players");
            DropForeignKey("dbo.Games", "FirstPlayer_Id", "dbo.Players");
            DropForeignKey("dbo.Games", "Player_Id", "dbo.Players");
            DropIndex("dbo.Games", new[] { "Winner_Id" });
            DropIndex("dbo.Games", new[] { "SecondPlayer_Id" });
            DropIndex("dbo.Games", new[] { "FirstPlayer_Id" });
            DropIndex("dbo.Games", new[] { "Player_Id" });
            DropTable("dbo.Players");
            DropTable("dbo.Games");
        }
    }
}
