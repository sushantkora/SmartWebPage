namespace SmartWebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dateTimeFix : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "DateofBirth", c => c.DateTime(nullable: true));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "DateofBirth", c => c.DateTime());
        }
    }
}
