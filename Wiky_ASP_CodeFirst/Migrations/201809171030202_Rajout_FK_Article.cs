namespace Wiky_ASP_CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Rajout_FK_Article : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Commentaires", "Article_Id_Article", "dbo.Articles");
            DropIndex("dbo.Commentaires", new[] { "Article_Id_Article" });
            RenameColumn(table: "dbo.Commentaires", name: "Article_Id_Article", newName: "Com_Id_Article");
            AlterColumn("dbo.Commentaires", "Com_Id_Article", c => c.Int(nullable: false));
            CreateIndex("dbo.Commentaires", "Com_Id_Article");
            AddForeignKey("dbo.Commentaires", "Com_Id_Article", "dbo.Articles", "Id_Article", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Commentaires", "Com_Id_Article", "dbo.Articles");
            DropIndex("dbo.Commentaires", new[] { "Com_Id_Article" });
            AlterColumn("dbo.Commentaires", "Com_Id_Article", c => c.Int());
            RenameColumn(table: "dbo.Commentaires", name: "Com_Id_Article", newName: "Article_Id_Article");
            CreateIndex("dbo.Commentaires", "Article_Id_Article");
            AddForeignKey("dbo.Commentaires", "Article_Id_Article", "dbo.Articles", "Id_Article");
        }
    }
}
