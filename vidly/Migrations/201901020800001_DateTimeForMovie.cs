namespace vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DateTimeForMovie : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Movies", "ReleaseDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Movies", "DateAddedToDatabase", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movies", "DateAddedToDatabase", c => c.String());
            AlterColumn("dbo.Movies", "ReleaseDate", c => c.String());
        }
    }
}
