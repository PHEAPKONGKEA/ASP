namespace testEF3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ClientTableModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        Clientid = c.Int(nullable: false, identity: true),
                        ClientName = c.String(nullable: false),
                        PhoneNumber = c.Int(nullable: false),
                        Addess = c.String(),
                    })
                .PrimaryKey(t => t.Clientid);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Clients");
        }
    }
}
