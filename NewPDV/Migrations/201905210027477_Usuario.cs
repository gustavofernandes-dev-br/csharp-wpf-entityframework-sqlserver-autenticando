namespace NewPDV.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Usuario : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.USUARIOACESSO",
                c => new
                    {
                        UAC_USUARIO = c.Int(nullable: false, identity: true),
                        UAC_ACESSO = c.String(),
                    })
                .PrimaryKey(t => t.UAC_USUARIO);
            
            CreateTable(
                "dbo.USUARIOS",
                c => new
                    {
                        USU_CODIGO = c.Int(nullable: false),
                        USU_USUARIO = c.String(nullable: false, maxLength: 30),
                        USU_SENHA = c.String(nullable: false),
                        USU_CADASTRO = c.DateTime(),
                        USU_ATUALIZACAO = c.DateTime(),
                        USU_INATIVO = c.Boolean(),
                    })
                .PrimaryKey(t => t.USU_CODIGO);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.USUARIOS");
            DropTable("dbo.USUARIOACESSO");
        }
    }
}
