Imports System.ComponentModel.DataAnnotations.Schema

Public Class ContractModels
    Public Property Id As Integer
    Public Property UserName As String
    Public Property IDNumber As String
    Public Property EmailAddress As String
    <ForeignKey("VehicleModels")>
    Public Property VehicleId As Integer
    Public Property CostPerDay As Integer
    Public Property ValidFrom As DateTime
    Public Property ValidTo As DateTime
    Public Property TotalAmount As Integer
    Public Property VehicleModels As VehicleModels

End Class
