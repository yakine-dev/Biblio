namespace Biblio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fk_plan_client : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clients", "PlanId", c => c.Int(nullable: false));
            CreateIndex("dbo.Clients", "PlanId");
            AddForeignKey("dbo.Clients", "PlanId", "dbo.Plans", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Clients", "PlanId", "dbo.Plans");
            DropIndex("dbo.Clients", new[] { "PlanId" });
            DropColumn("dbo.Clients", "PlanId");
        }
    }
}
