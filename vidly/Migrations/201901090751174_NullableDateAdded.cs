namespace vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NullableDateAdded : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Movies", "DateAddedToDatabase", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movies", "DateAddedToDatabase", c => c.DateTime(nullable: false));
        }
    }
}
