Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class setupcontracts
        Inherits DbMigration
    
        Public Overrides Sub Up()
            CreateTable(
                "dbo.ContractModels",
                Function(c) New With
                    {
                        .Id = c.Int(nullable := False, identity := True),
                        .UserName = c.String(),
                        .IDNumber = c.String(),
                        .EmailAddress = c.String(),
                        .VehicleId = c.Int(nullable := False),
                        .CostPerDay = c.Int(nullable := False),
                        .ValidFrom = c.DateTime(nullable := False),
                        .ValidTo = c.DateTime(nullable := False),
                        .TotalAmount = c.Int(nullable := False)
                    }) _
                .PrimaryKey(Function(t) t.Id)
            
        End Sub
        
        Public Overrides Sub Down()
            DropTable("dbo.ContractModels")
        End Sub
    End Class
End Namespace
