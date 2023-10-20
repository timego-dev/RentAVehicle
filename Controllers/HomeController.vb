Imports Microsoft.AspNet.Identity
Imports Microsoft.AspNet.Identity.Owin

Public Class HomeController
    Inherits Controller

    <AllowAnonymous>
    Public Function Index() As ActionResult
        Return View()
    End Function
End Class
