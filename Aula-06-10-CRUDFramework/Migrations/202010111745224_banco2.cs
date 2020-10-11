namespace Aula_06_10_CRUDFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class banco2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SalaAulas",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        professor = c.String(),
                        sala = c.Int(nullable: false),
                        curso = c.String(),
                        data = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SalaAulas");
        }
    }
}
