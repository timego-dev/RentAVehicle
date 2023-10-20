Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class InitialCreate
        Inherits DbMigration
    
        Public Overrides Sub Up()
            CreateTable(
                "dbo.VehicleModels",
                Function(c) New With
                    {
                        .Id = c.String(nullable := False, maxLength := 128),
                        .Name = c.String(),
                        .Model = c.String(),
                        .Price = c.String()
                    }) _
                .PrimaryKey(Function(t) t.Id)
            
        End Sub
        
        Public Overrides Sub Down()
            DropTable("dbo.VehicleModels")
        End Sub
    End Class
End Namespace
