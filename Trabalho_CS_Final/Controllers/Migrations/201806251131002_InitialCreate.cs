namespace Controllers.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        ID_Cliente = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 30),
                        Login = c.String(nullable: false, maxLength: 30),
                        Senha = c.String(nullable: false, maxLength: 30),
                        Email = c.String(nullable: false, maxLength: 30),
                        Ativo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID_Cliente);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Clientes");
        }
    }
}
