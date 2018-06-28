namespace Controllers.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Computadors",
                c => new
                    {
                        ID_Computador = c.Int(nullable: false, identity: true),
                        ID_Cliente = c.Int(nullable: false),
                        ValorTotal = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Fonte_ID_Fonte = c.Int(),
                        HD_ID_HD = c.Int(),
                        Memoria_ID_Memoria = c.Int(),
                        PlacaMae_ID_PlacaMae = c.Int(),
                        Processador_ID_Processador = c.Int(),
                    })
                .PrimaryKey(t => t.ID_Computador)
                .ForeignKey("dbo.Fontes", t => t.Fonte_ID_Fonte)
                .ForeignKey("dbo.HDs", t => t.HD_ID_HD)
                .ForeignKey("dbo.Memorias", t => t.Memoria_ID_Memoria)
                .ForeignKey("dbo.PlacaMaes", t => t.PlacaMae_ID_PlacaMae)
                .ForeignKey("dbo.Processadors", t => t.Processador_ID_Processador)
                .Index(t => t.Fonte_ID_Fonte)
                .Index(t => t.HD_ID_HD)
                .Index(t => t.Memoria_ID_Memoria)
                .Index(t => t.PlacaMae_ID_PlacaMae)
                .Index(t => t.Processador_ID_Processador);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Computadors", "Processador_ID_Processador", "dbo.Processadors");
            DropForeignKey("dbo.Computadors", "PlacaMae_ID_PlacaMae", "dbo.PlacaMaes");
            DropForeignKey("dbo.Computadors", "Memoria_ID_Memoria", "dbo.Memorias");
            DropForeignKey("dbo.Computadors", "HD_ID_HD", "dbo.HDs");
            DropForeignKey("dbo.Computadors", "Fonte_ID_Fonte", "dbo.Fontes");
            DropIndex("dbo.Computadors", new[] { "Processador_ID_Processador" });
            DropIndex("dbo.Computadors", new[] { "PlacaMae_ID_PlacaMae" });
            DropIndex("dbo.Computadors", new[] { "Memoria_ID_Memoria" });
            DropIndex("dbo.Computadors", new[] { "HD_ID_HD" });
            DropIndex("dbo.Computadors", new[] { "Fonte_ID_Fonte" });
            DropTable("dbo.Computadors");
        }
    }
}
