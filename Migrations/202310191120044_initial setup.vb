Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class initialsetup
        Inherits DbMigration
    
        Public Overrides Sub Up()
            DropPrimaryKey("dbo.VehicleModels")
            AddColumn("dbo.VehicleModels", "Type", Function(c) c.String())
            AddColumn("dbo.VehicleModels", "Year", Function(c) c.String())
            AddColumn("dbo.VehicleModels", "CostPerDay", Function(c) c.Int(nullable := False))
            AddColumn("dbo.VehicleModels", "Availability", Function(c) c.Boolean(nullable := False))
            AlterColumn("dbo.VehicleModels", "Id", Function(c) c.Int(nullable := False, identity := True))
            AddPrimaryKey("dbo.VehicleModels", "Id")
            DropColumn("dbo.VehicleModels", "Price")
        End Sub
        
        Public Overrides Sub Down()
            AddColumn("dbo.VehicleModels", "Price", Function(c) c.String())
            DropPrimaryKey("dbo.VehicleModels")
            AlterColumn("dbo.VehicleModels", "Id", Function(c) c.String(nullable := False, maxLength := 128))
            DropColumn("dbo.VehicleModels", "Availability")
            DropColumn("dbo.VehicleModels", "CostPerDay")
            DropColumn("dbo.VehicleModels", "Year")
            DropColumn("dbo.VehicleModels", "Type")
            AddPrimaryKey("dbo.VehicleModels", "Id")
        End Sub
    End Class
End Namespace
