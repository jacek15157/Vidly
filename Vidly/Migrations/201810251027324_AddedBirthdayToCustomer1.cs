namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedBirthdayToCustomer1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "Birthday", c => c.DateTime());
            Sql("ALTER TABLE Customers ALTER COLUMN Birthday DateTime; ");
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "Birthday", c => c.Int());
        }
    }
}
