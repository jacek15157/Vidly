namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddGenres : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Genres SET Name = 'Action' WHERE Id = 1");
            Sql("UPDATE Genres SET Name = 'Horror' WHERE Id = 2");
            Sql("UPDATE Genres SET Name = 'Thriller' WHERE Id = 3");
            Sql("UPDATE Genres SET Name = 'Comedy' WHERE Id = 4");
            Sql("UPDATE Genres SET Name = 'Drama' WHERE Id = 5");
        }
        
        public override void Down()
        {
        }
    }
}
