﻿namespace SmartWebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingDateOfBirthpropertytoCustomer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "DateofBirth", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "DateofBirth");
        }
    }
}
