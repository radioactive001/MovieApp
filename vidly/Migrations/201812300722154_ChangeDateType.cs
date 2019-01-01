namespace vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeDateType : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Movies", "ReleaseDate", c => c.String());
            AlterColumn("dbo.Movies", "DateAddedToDatabase", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movies", "DateAddedToDatabase", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Movies", "ReleaseDate", c => c.DateTime(nullable: false));
        }
    }
}
