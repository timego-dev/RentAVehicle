Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc
Imports RentAVehicle
Imports RentAVehicle.Data
Imports Microsoft.AspNet.Identity
Imports Microsoft.AspNet.Identity.Owin

Namespace Controllers
    Public Class ContractController
        Inherits System.Web.Mvc.Controller

        Private db As New RentAVehicleContext

        ' GET: Contract
        Function Index() As ActionResult
            Dim contractModels = db.ContractModels.Include(Function(c) c.VehicleModels)
            Return View(contractModels.ToList())
        End Function

        ' GET: Contract/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim contractModels As ContractModels = db.ContractModels.Find(id)
            If IsNothing(contractModels) Then
                Return HttpNotFound()
            End If
            Return View(contractModels)
        End Function

        ' GET: Contract/Create
        Function Create(ByVal vehicleId As Integer?) As ActionResult
            ViewBag.VehicleId = New SelectList(db.VehicleModels, "Id", "Name", vehicleId)
            Return View()
        End Function

        Function GetVehicleDetails(ByVal id As Integer) As VehicleModels
            Return db.VehicleModels.Find(id)
        End Function

        ' POST: Contract/Create
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="Id,UserName,IDNumber,EmailAddress,VehicleId,CostPerDay,ValidFrom,ValidTo,TotalAmount")> ByVal contractModels As ContractModels) As ActionResult
            If ModelState.IsValid Then
                Dim vehicleModels As VehicleModels = GetVehicleDetails(contractModels.VehicleId)
                contractModels.CostPerDay = vehicleModels.CostPerDay
                contractModels.TotalAmount = vehicleModels.CostPerDay
                db.ContractModels.Add(contractModels)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.VehicleId = New SelectList(db.VehicleModels, "Id", "Name", contractModels.VehicleId)
            Return View(contractModels)
        End Function

        ' GET: Contract/Edit/5
        <Authorize>
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim contractModels As ContractModels = db.ContractModels.Find(id)
            If IsNothing(contractModels) Then
                Return HttpNotFound()
            End If
            ViewBag.VehicleId = New SelectList(db.VehicleModels, "Id", "Name", contractModels.VehicleId)
            Return View(contractModels)
        End Function

        ' POST: Contract/Edit/5
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <Authorize>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="Id,UserName,IDNumber,EmailAddress,VehicleId,CostPerDay,ValidFrom,ValidTo,TotalAmount")> ByVal contractModels As ContractModels) As ActionResult
            If ModelState.IsValid Then
                db.Entry(contractModels).State = EntityState.Modified
                Dim vehicleModels As VehicleModels = GetVehicleDetails(contractModels.VehicleId)
                contractModels.TotalAmount = VehicleModels.CostPerDay
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.VehicleId = New SelectList(db.VehicleModels, "Id", "Name", contractModels.VehicleId)
            Return View(contractModels)
        End Function

        ' GET: Contract/Delete/5
        <Authorize>
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim contractModels As ContractModels = db.ContractModels.Find(id)
            If IsNothing(contractModels) Then
                Return HttpNotFound()
            End If
            Return View(contractModels)
        End Function

        ' POST: Contract/Delete/5
        <HttpPost()>
        <Authorize>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim contractModels As ContractModels = db.ContractModels.Find(id)
            db.ContractModels.Remove(contractModels)
            db.SaveChanges()
            Return RedirectToAction("Index")
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing) Then
                db.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub
    End Class
End Namespace
