namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenresReleaseDateDateAddedNumberInStockInMovie : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies( Name, Genre, ReleaseDate, DateAdded, NumberInStock) VALUES ( 'Hangover',  'Comedy', 10/10/2010, 12/12/2018, 15)");
            Sql("INSERT INTO Movies( Name, Genre, ReleaseDate, DateAdded, NumberInStock) VALUES ( 'Millers',  'Comedy', 5/12/2012, 12/12/2018, 16)");
            Sql("INSERT INTO Movies( Name, Genre, ReleaseDate, DateAdded, NumberInStock) VALUES ( 'Die Hard',  'Action', 3/7/1988, 12/12/2018, 17)");
            Sql("INSERT INTO Movies( Name, Genre, ReleaseDate, DateAdded, NumberInStock) VALUES ( 'Superman',  'Action', 11/9/1978, 12/12/2018, 17)");
        }
        
        public override void Down()
        {
        }
    }
}
