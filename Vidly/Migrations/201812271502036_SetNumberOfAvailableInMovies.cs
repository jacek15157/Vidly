namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SetNumberOfAvailableInMovies : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Movies SET NumberOfAvailable = NumberInStock");
        }
        
        public override void Down()
        {
            Sql("UPDATE Movies SET NumberOfAvailable = NULL");
        }
    }
}
