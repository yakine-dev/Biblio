namespace Biblio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class table_client_supression_prenom : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Clients", "Prenom");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Clients", "Prenom", c => c.String());
        }
    }
}
