namespace Controllers.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial4 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Computadors", name: "_Fonte_ID_Fonte", newName: "Fonte_ID_Fonte");
            RenameColumn(table: "dbo.Computadors", name: "_Memoria_ID_Memoria", newName: "Memoria_ID_Memoria");
            RenameColumn(table: "dbo.Computadors", name: "_PlacaMae_ID_PlacaMae", newName: "PlacaMae_ID_PlacaMae");
            RenameColumn(table: "dbo.Computadors", name: "_Processador_ID_Processador", newName: "Processador_ID_Processador");
            RenameIndex(table: "dbo.Computadors", name: "IX__Fonte_ID_Fonte", newName: "IX_Fonte_ID_Fonte");
            RenameIndex(table: "dbo.Computadors", name: "IX__Memoria_ID_Memoria", newName: "IX_Memoria_ID_Memoria");
            RenameIndex(table: "dbo.Computadors", name: "IX__PlacaMae_ID_PlacaMae", newName: "IX_PlacaMae_ID_PlacaMae");
            RenameIndex(table: "dbo.Computadors", name: "IX__Processador_ID_Processador", newName: "IX_Processador_ID_Processador");
            AddColumn("dbo.Computadors", "ValorTotal", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("dbo.Computadors", "_ValorTotal");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Computadors", "_ValorTotal", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("dbo.Computadors", "ValorTotal");
            RenameIndex(table: "dbo.Computadors", name: "IX_Processador_ID_Processador", newName: "IX__Processador_ID_Processador");
            RenameIndex(table: "dbo.Computadors", name: "IX_PlacaMae_ID_PlacaMae", newName: "IX__PlacaMae_ID_PlacaMae");
            RenameIndex(table: "dbo.Computadors", name: "IX_Memoria_ID_Memoria", newName: "IX__Memoria_ID_Memoria");
            RenameIndex(table: "dbo.Computadors", name: "IX_Fonte_ID_Fonte", newName: "IX__Fonte_ID_Fonte");
            RenameColumn(table: "dbo.Computadors", name: "Processador_ID_Processador", newName: "_Processador_ID_Processador");
            RenameColumn(table: "dbo.Computadors", name: "PlacaMae_ID_PlacaMae", newName: "_PlacaMae_ID_PlacaMae");
            RenameColumn(table: "dbo.Computadors", name: "Memoria_ID_Memoria", newName: "_Memoria_ID_Memoria");
            RenameColumn(table: "dbo.Computadors", name: "Fonte_ID_Fonte", newName: "_Fonte_ID_Fonte");
        }
    }
}
