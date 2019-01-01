namespace vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBirthDay : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "BirthDate", c => c.String());
            Sql("UPDATE Customers SET BirthDate='21/08/1990' WHERE Id=1");
            Sql("UPDATE Customers SET BirthDate='15/02/1985' WHERE Id=3");
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "BirthDate");
        }
    }
}
