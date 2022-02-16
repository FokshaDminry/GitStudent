namespace OOP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OnModel : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Vehicles");
            AlterColumn("dbo.Vehicles", "ID", c => c.Guid());
            AlterColumn("dbo.Vehicles", "Id", c => c.Guid(nullable: false));
            AddPrimaryKey("dbo.Vehicles", "Id");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Vehicles");
            AlterColumn("dbo.Vehicles", "Id", c => c.Guid());
            AlterColumn("dbo.Vehicles", "ID", c => c.Guid(nullable: false));
            AddPrimaryKey("dbo.Vehicles", "Id");
        }
    }
}
