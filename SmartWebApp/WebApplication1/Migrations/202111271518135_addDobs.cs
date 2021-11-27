namespace SmartWebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addDobs : DbMigration
    {
        public override void Up()
        {

           /* Sql("UPDATE Customers SET DateofBirth = '07/01/1995' WHERE Id = 1");
            Sql("UPDATE Customers SET DateofBirth = '24/01/2007' WHERE Id = 2");
            Sql("UPDATE Customers SET DateofBirth = '15/04/2015' WHERE Id = 6");
            Sql("UPDATE Customers SET DateofBirth = '' WHERE Id = 7");
            Sql("UPDATE Customers SET DateofBirth = '02/01/2001' WHERE Id = 8");
            Sql("UPDATE Customers SET DateofBirth = '' WHERE Id = 9");*/
        }
        
        public override void Down()
        {
        }
    }
}
