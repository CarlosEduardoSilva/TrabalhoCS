namespace Controllers.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Mudanca : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Fontes",
                c => new
                    {
                        ID_Fonte = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Valor = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.ID_Fonte);
            
            CreateTable(
                "dbo.HDs",
                c => new
                    {
                        ID_HD = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Valor = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.ID_HD);
            
            CreateTable(
                "dbo.Memorias",
                c => new
                    {
                        ID_Memoria = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Valor = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.ID_Memoria);
            
            CreateTable(
                "dbo.PlacaMaes",
                c => new
                    {
                        ID_PlacaMae = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Valor = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.ID_PlacaMae);
            
            CreateTable(
                "dbo.Processadors",
                c => new
                    {
                        ID_Processador = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Valor = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.ID_Processador);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Processadors");
            DropTable("dbo.PlacaMaes");
            DropTable("dbo.Memorias");
            DropTable("dbo.HDs");
            DropTable("dbo.Fontes");
        }
    }
}
