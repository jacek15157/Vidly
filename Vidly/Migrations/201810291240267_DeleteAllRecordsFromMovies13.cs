namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteAllRecordsFromMovies13 : DbMigration
    {
        public override void Up()
        {
        }
        
        public override void Down()
        {
            Sql("DELETE FROM Movies");
        }
    }
}
