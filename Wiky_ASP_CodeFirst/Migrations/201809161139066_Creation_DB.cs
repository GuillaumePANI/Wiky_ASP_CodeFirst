namespace Wiky_ASP_CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Creation_DB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Articles",
                c => new
                    {
                        Id_Article = c.Int(nullable: false, identity: true),
                        Theme = c.String(),
                        Auteur = c.String(),
                        DateCreation = c.DateTime(nullable: false),
                        Image = c.String(),
                        Contenu = c.String(),
                    })
                .PrimaryKey(t => t.Id_Article);
            
            CreateTable(
                "dbo.Commentaires",
                c => new
                    {
                        Id_Commentaire = c.Int(nullable: false, identity: true),
                        Auteur = c.String(),
                        DateComentaire = c.DateTime(nullable: false),
                        Contenu = c.String(),
                        Article_Id_Article = c.Int(),
                    })
                .PrimaryKey(t => t.Id_Commentaire)
                .ForeignKey("dbo.Articles", t => t.Article_Id_Article)
                .Index(t => t.Article_Id_Article);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Commentaires", "Article_Id_Article", "dbo.Articles");
            DropIndex("dbo.Commentaires", new[] { "Article_Id_Article" });
            DropTable("dbo.Commentaires");
            DropTable("dbo.Articles");
        }
    }
}
