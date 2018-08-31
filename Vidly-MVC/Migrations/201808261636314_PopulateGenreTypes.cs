namespace Vidly_MVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenreTypes : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO GenreTypes (Id, Name) VALUES (1, 'Action')");
            Sql("INSERT INTO GenreTypes (Id, Name) VALUES (2, 'Comedy')");
            Sql("INSERT INTO GenreTypes (Id, Name) VALUES (3, 'Horror')");
            Sql("INSERT INTO GenreTypes (Id, Name) VALUES (4, 'Thriller')");
            Sql("INSERT INTO GenreTypes (Id, Name) VALUES (5, 'Romance')");
            Sql("INSERT INTO GenreTypes (Id, Name) VALUES (6, 'Family')");
            Sql("INSERT INTO GenreTypes (Id, Name) VALUES (7, 'Mystery')");
        }
        
        public override void Down()
        {
        }
    }
}
