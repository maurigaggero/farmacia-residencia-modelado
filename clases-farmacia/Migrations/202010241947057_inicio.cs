namespace clases_farmacia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inicio : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Inventario",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Codigo = c.Long(nullable: false),
                        Cantidad = c.Int(nullable: false),
                        Fecha_Vencimiento = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Medicamentos", t => t.Codigo, cascadeDelete: true)
                .Index(t => t.Codigo);
            
            CreateTable(
                "dbo.Medicamentos",
                c => new
                    {
                        Codigo = c.Long(nullable: false),
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false),
                        Laboratorio = c.String(nullable: false),
                        Unidad = c.String(),
                    })
                .PrimaryKey(t => t.Codigo);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Inventario", "Codigo", "dbo.Medicamentos");
            DropIndex("dbo.Inventario", new[] { "Codigo" });
            DropTable("dbo.Medicamentos");
            DropTable("dbo.Inventario");
        }
    }
}
