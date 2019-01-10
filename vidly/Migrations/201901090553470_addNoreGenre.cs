namespace vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addNoreGenre : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Genres SET Name='Mystery' WHERE Id=4");
            Sql("INSERT INTO Genres (Id, Name) VALUES (5, 'Action')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (6, 'Crime')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (7, 'War')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (8, 'Musical')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (9, 'Documentary')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (10, 'Romance')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (11, 'Thriller')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (12, 'Science-Fiction')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (13, 'Western')");
        }
        
        public override void Down()
        {
        }
    }
}
