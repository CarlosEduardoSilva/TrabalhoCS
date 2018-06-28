namespace Controllers.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Computadors", "HDID", c => c.Int(nullable: false));
            AddColumn("dbo.Computadors", "ProcessadorID", c => c.Int(nullable: false));
            AddColumn("dbo.Computadors", "PlacamaeID", c => c.Int(nullable: false));
            AddColumn("dbo.Computadors", "FonteID", c => c.Int(nullable: false));
            AddColumn("dbo.Computadors", "MemoriaID", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Computadors", "MemoriaID");
            DropColumn("dbo.Computadors", "FonteID");
            DropColumn("dbo.Computadors", "PlacamaeID");
            DropColumn("dbo.Computadors", "ProcessadorID");
            DropColumn("dbo.Computadors", "HDID");
        }
    }
}
