namespace Aula_06_10_CRUDFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class banco3 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.SalaAulas", "data", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.SalaAulas", "data", c => c.Int(nullable: false));
        }
    }
}
