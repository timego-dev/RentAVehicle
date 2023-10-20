Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class setupcontracts_new2
        Inherits DbMigration
    
        Public Overrides Sub Up()
            CreateIndex("dbo.ContractModels", "VehicleId")
            AddForeignKey("dbo.ContractModels", "VehicleId", "dbo.VehicleModels", "Id", cascadeDelete := True)
        End Sub
        
        Public Overrides Sub Down()
            DropForeignKey("dbo.ContractModels", "VehicleId", "dbo.VehicleModels")
            DropIndex("dbo.ContractModels", New String() { "VehicleId" })
        End Sub
    End Class
End Namespace
