namespace Garage.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class carstable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cars",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Ownername = c.String(),
                        Numofcar = c.Int(nullable: false),
                        Status = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Cars");
        }
    }
}
