namespace Controllers.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial2 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Computadors", name: "Processador_ID_Processador", newName: "_Processador_ID_Processador");
            RenameIndex(table: "dbo.Computadors", name: "IX_Processador_ID_Processador", newName: "IX__Processador_ID_Processador");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Computadors", name: "IX__Processador_ID_Processador", newName: "IX_Processador_ID_Processador");
            RenameColumn(table: "dbo.Computadors", name: "_Processador_ID_Processador", newName: "Processador_ID_Processador");
        }
    }
}
