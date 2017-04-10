namespace Shop.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NowyModel123222 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Wszystkies", "Rodzaj", c => c.Int(nullable: false));
           
        }
        
        public override void Down()
        {
            AddColumn("dbo.Wszystkies", "test", c => c.String());
           
        }
    }
}
