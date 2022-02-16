namespace OOP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addModel : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Vehicles");
            AddColumn("dbo.Vehicles", "weight", c => c.Int());
            AlterColumn("dbo.Vehicles", "ID", c => c.Guid());
            AlterColumn("dbo.Vehicles", "Id", c => c.Guid(nullable: false));
            AddPrimaryKey("dbo.Vehicles", "Id");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Vehicles");
            AlterColumn("dbo.Vehicles", "Id", c => c.Guid());
            AlterColumn("dbo.Vehicles", "ID", c => c.Guid(nullable: false));
            DropColumn("dbo.Vehicles", "weight");
            AddPrimaryKey("dbo.Vehicles", "Id");
        }
    }
}
