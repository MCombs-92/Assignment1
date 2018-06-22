namespace Application1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedvehiclecontroller : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Vehicles", "Model", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Vehicles", "Model", c => c.Int(nullable: false));
        }
    }
}
