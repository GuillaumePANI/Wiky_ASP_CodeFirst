namespace Wiky_ASP_CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_constraint : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Articles", "Theme", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Articles", "Auteur", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Articles", "Contenu", c => c.String(nullable: false));
            AlterColumn("dbo.Commentaires", "Auteur", c => c.String(nullable: false));
            AlterColumn("dbo.Commentaires", "Contenu", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Commentaires", "Contenu", c => c.String());
            AlterColumn("dbo.Commentaires", "Auteur", c => c.String());
            AlterColumn("dbo.Articles", "Contenu", c => c.String());
            AlterColumn("dbo.Articles", "Auteur", c => c.String());
            AlterColumn("dbo.Articles", "Theme", c => c.String());
        }
    }
}
