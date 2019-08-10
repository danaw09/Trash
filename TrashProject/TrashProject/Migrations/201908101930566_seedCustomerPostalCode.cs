namespace TrashProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seedCustomerPostalCode : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "PostalCode", c => c.Int(nullable: false));
            AlterColumn("dbo.Customers", "Address", c => c.String());
            AlterColumn("dbo.Customers", "WeeklyPickupDayId", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "WeeklyPickupDayId", c => c.Int());
            AlterColumn("dbo.Customers", "Address", c => c.Int(nullable: false));
            DropColumn("dbo.Customers", "PostalCode");
        }
    }
}
