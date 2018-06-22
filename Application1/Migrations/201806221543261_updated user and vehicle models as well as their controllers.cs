namespace Application1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateduserandvehiclemodelsaswellastheircontrollers : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Owners", "Name", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Owners", "City", c => c.String(nullable: false, maxLength: 55));
            AlterColumn("dbo.Owners", "State", c => c.String(nullable: false, maxLength: 2));
            AlterColumn("dbo.Vehicles", "Vin", c => c.String(nullable: false, maxLength: 55));
            AlterColumn("dbo.Vehicles", "Make", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Vehicles", "Model", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Vehicles", "Year", c => c.String(nullable: false, maxLength: 4));
            CreateIndex("dbo.Vehicles", "Vin", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.Vehicles", new[] { "Vin" });
            AlterColumn("dbo.Vehicles", "Year", c => c.Int(nullable: false));
            AlterColumn("dbo.Vehicles", "Model", c => c.String());
            AlterColumn("dbo.Vehicles", "Make", c => c.String());
            AlterColumn("dbo.Vehicles", "Vin", c => c.String());
            AlterColumn("dbo.Owners", "State", c => c.String());
            AlterColumn("dbo.Owners", "City", c => c.String());
            AlterColumn("dbo.Owners", "Name", c => c.String());
        }
    }
}
