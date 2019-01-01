namespace vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenre : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Id, Name) VALUES (1, 'Comedy')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (2, 'Horror')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (3, 'Drama')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (4, 'Mystry')");
        }
        
        public override void Down()
        {
        }
    }
}
