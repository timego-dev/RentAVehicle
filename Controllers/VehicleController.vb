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
    Public Class VehicleController
        Inherits System.Web.Mvc.Controller

        Private db As New RentAVehicleContext

        Function IsAvailableForRent(ByVal vehicleModels As VehicleModels) As Boolean
            Dim contractModels As List(Of ContractModels) = db.ContractModels.Where(Function(c) c.VehicleId = vehicleModels.Id).ToList()
            Dim AvailabeForRent As Boolean = True
            For i As Integer = 0 To contractModels.Count() - 1
                If (AvailabeForRent And DateTime.Now() >= contractModels.ElementAt(i).ValidFrom And DateTime.Now() <= contractModels.ElementAt(i).ValidTo) Then
                    AvailabeForRent = False
                End If
            Next
            Return AvailabeForRent
        End Function

        ' GET: Vehicle
        Function Index() As ActionResult
            Return View(db.VehicleModels.ToList())
        End Function

        ' GET: Vehicle/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim vehicleModels As VehicleModels = db.VehicleModels.Find(id)
            ViewBag.AvailableForRent = IsAvailableForRent(vehicleModels)
            If IsNothing(vehicleModels) Then
                Return HttpNotFound()
            End If
            Return View(vehicleModels)
        End Function

        ' GET: Vehicle/Create
        <Authorize>
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: Vehicle/Create
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <Authorize>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="Name,Type,Model,Year,CostPerDay,Availability")> ByVal vehicleModels As VehicleModels) As ActionResult
            If ModelState.IsValid Then
                db.VehicleModels.Add(vehicleModels)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(vehicleModels)
        End Function

        ' GET: Vehicle/Edit/5
        <Authorize>
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim vehicleModels As VehicleModels = db.VehicleModels.Find(id)
            If IsNothing(vehicleModels) Then
                Return HttpNotFound()
            End If
            Return View(vehicleModels)
        End Function

        ' POST: Vehicle/Edit/5
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <Authorize>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="Id,Name,Type,Model,Year,CostPerDay,Availability")> ByVal vehicleModels As VehicleModels) As ActionResult
            If ModelState.IsValid Then
                db.Entry(vehicleModels).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(vehicleModels)
        End Function

        ' GET: Vehicle/Delete/5
        <Authorize>
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim vehicleModels As VehicleModels = db.VehicleModels.Find(id)
            If IsNothing(vehicleModels) Then
                Return HttpNotFound()
            End If
            Return View(vehicleModels)
        End Function

        ' POST: Vehicle/Delete/5
        <HttpPost()>
        <Authorize>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim vehicleModels As VehicleModels = db.VehicleModels.Find(id)
            db.VehicleModels.Remove(vehicleModels)
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
