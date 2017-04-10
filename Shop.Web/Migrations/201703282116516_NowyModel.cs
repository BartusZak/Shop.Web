namespace Shop.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NowyModel : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Wszystkies", "Cena", c => c.Single(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Wszystkies", "Cena", c => c.Double(nullable: false));
        }
    }
}
