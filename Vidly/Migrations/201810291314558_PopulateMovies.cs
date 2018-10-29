namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMovies : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies(Name, GenreId, ReleaseDate,DateAdded, NumberInStock) VALUES ( 'Hangover',4,  '01.01.2010', '01.01.2010', 10)");
            Sql("INSERT INTO Movies(Name, GenreId, ReleaseDate,DateAdded, NumberInStock) VALUES ( 'Die Hard',1,  '01.01.1988', '01.01.2010', 5)");
            Sql("INSERT INTO Movies(Name, GenreId, ReleaseDate,DateAdded, NumberInStock) VALUES ( 'Stupid and Stupider',4,  '01.01.1994', '01.01.2010', 15)");
            Sql("INSERT INTO Movies(Name, GenreId, ReleaseDate,DateAdded, NumberInStock) VALUES ( 'Transformers',1,  '01.01.2007', '01.01.2010', 166)");
            
        }
        
        public override void Down()
        {
        }
    }
}
