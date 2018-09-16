namespace Wiky_ASP_CodeFirst.BDD_CF
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using Wiky_ASP_CodeFirst.Models;

    public class Wiky_CF : DbContext
    {
        // Your context has been configured to use a 'Wiky_CF' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Wiky_ASP_CodeFirst.BDD_CF.Wiky_CF' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'Wiky_CF' 
        // connection string in the application configuration file.
        public Wiky_CF()
            : base("name=Wiky_CF")
        {
        }
        public virtual DbSet<Article> Articles { get; set; }
        public virtual DbSet<Commentaire> Commentaires { get; set; }
        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}