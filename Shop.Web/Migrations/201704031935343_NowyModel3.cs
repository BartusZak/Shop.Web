namespace Shop.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NowyModel3 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Wszystkies", "Cena", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Wszystkies", "Cena", c => c.Single(nullable: false));
        }
    }
}
