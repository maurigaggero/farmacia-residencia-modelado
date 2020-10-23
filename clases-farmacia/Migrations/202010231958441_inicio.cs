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
                        Id = c.Int(nullable: false),
                        Cantidad = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Medicamentos", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.Medicamentos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Codigo = c.Int(nullable: false),
                        Nombre = c.String(nullable: false),
                        Laboratorio = c.String(nullable: false),
                        Fecha_Vencimiento = c.DateTime(nullable: false),
                        Unidad = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Inventario", "Id", "dbo.Medicamentos");
            DropIndex("dbo.Inventario", new[] { "Id" });
            DropTable("dbo.Medicamentos");
            DropTable("dbo.Inventario");
        }
    }
}
