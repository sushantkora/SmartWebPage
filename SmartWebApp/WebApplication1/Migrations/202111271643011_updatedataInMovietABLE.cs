namespace SmartWebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedataInMovietABLE : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies(Id,Title,Date,IMDB,Genre) VALUES (1,The Shawshank Redemption,28/10/1999,9.2,Suspense)");
            Sql("INSERT INTO Movies(Id,Title,Date,IMDB,Genre) VALUES (2, The Godfather,09/04/2005,9.1,Dark)");
            Sql("INSERT INTO Movies(Id,Title,Date,IMDB,Genre) VALUES (3, The Dark Knight,28/10/1999,9.0,Comedy)");
            Sql("INSERT INTO Movies(Id,Title,Date,IMDB,Genre) VALUES (4,The Shawshank Redemption,28/10/1999,8.8,Suspense)");
            Sql("INSERT INTO Movies(Id,Title,Date,IMDB,Genre) VALUES (5,12 Angry Men,28/10/1999,8.2,Comedy)");
            Sql("INSERT INTO Movies(Id,Title,Date,IMDB,Genre) VALUES (6, Schindler's Lis,28/10/1999,8.9,Suspense)");
            Sql("INSERT INTO Movies(Id,Title,Date,IMDB,Genre) VALUES (7, The Lord of the Rings: The Return of the King,28/10/1999,9.1,Comedy)");
            Sql("INSERT INTO Movies(Id,Title,Date,IMDB,Genre) VALUES (8, Fight Club,28/10/1999,8.1,Suspense)");
            Sql("INSERT INTO Movies(Id,Title,Date,IMDB,Genre) VALUES (9,Inception,28/10/1999,7.2,Suspense)");
            Sql("INSERT INTO Movies(Id,Title,Date,IMDB,Genre) VALUES (10, One Flew Over the Cuckoo's Nest,28/10/1999,9.2,Comedy)");
            Sql("INSERT INTO Movies(Id,Title,Date,IMDB,Genre) VALUES (11, The Silence of the Lambs,28/10/1999,6.8,Comedy)");
            Sql("INSERT INTO Movies(Id,Title,Date,IMDB,Genre) VALUES (12, Life Is Beautiful ,28/10/1999,7.6,Suspense)");
        }
        
        public override void Down()
        {
        }
    }
}
