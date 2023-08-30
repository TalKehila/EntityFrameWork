namespace ConsoleMigration2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Strt : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Customers", newName: "People");
            AddColumn("dbo.People", "Status", c => c.Boolean());
            AddColumn("dbo.People", "Discriminator", c => c.String(nullable: false, maxLength: 128));
        }
        
        public override void Down()
        {
            DropColumn("dbo.People", "Discriminator");
            DropColumn("dbo.People", "Status");
            RenameTable(name: "dbo.People", newName: "Customers");
        }
    }
}
