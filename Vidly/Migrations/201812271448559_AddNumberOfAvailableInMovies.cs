namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNumberOfAvailableInMovies : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "NumberOfAvailable", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "NumberOfAvailable");
        }
    }
}
