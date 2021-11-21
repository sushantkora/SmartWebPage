namespace SmartWebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMembershipType_3 : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MembershipTypes(Id,SignUpFee,DurationInMonths,DurationRate) VALUES (1,0,0,1)");
            Sql("INSERT INTO MembershipTypes(Id,SignUpFee,DurationInMonths,DurationRate) VALUES (2,299,1,10)");
            Sql("INSERT INTO MembershipTypes(Id,SignUpFee,DurationInMonths,DurationRate) VALUES (3,599,0,15)");
            Sql("INSERT INTO MembershipTypes(Id,SignUpFee,DurationInMonths,DurationRate) VALUES (4,999,0,20)");
        }
        
        public override void Down()
        {
        }
    }
}
