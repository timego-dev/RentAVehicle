<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="utf-8" />
    <title>@ViewBag.Title - My ASP.NET Application</title>
    <link href="~/favicon.ico" rel="shortcut icon" type="image/x-icon" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    @Styles.Render("~/Content/css")
    @Scripts.Render("~/bundles/modernizr")
</head>
<body>
    <nav class="navbar navbar-expand-sm navbar-toggleable-sm navbar-dark bg-dark">
        <div class="container">
            @Html.ActionLink("Rent A Vehicle", "Index", "Home", New With {.area = ""}, New With {.class = "navbar-brand"})
            <button type="button" class="navbar-toggler" data-bs-toggle="collapse" data-bs-target=".navbar-collapse" title="Toggle navigation" aria-controls="navbarSupportedContent"
                    aria-expanded="false" aria-label="Toggle navigation">
                <span class="navbar-toggler-icon"></span>
            </button>
            <div class="collapse navbar-collapse d-sm-inline-flex justify-content-between">
                <ul class="navbar-nav flex-grow-1">
                    <li>@Html.ActionLink("Vehicles", "Index", "Vehicle", New With {.area = ""}, New With {.class = "nav-link"})</li>
                    @If Request.IsAuthenticated Then
                        @<li>@Html.ActionLink("Contracts", "Index", "Contract", New With {.area = ""}, New With {.class = "nav-link"})</li>
                    End If
                </ul>
                @Html.Partial("_LoginPartial")
            </div>
        </div>
    </nav>
    <div Class="container body-content">
        @RenderBody()
        @RenderSection("SPAViews", required:=False)
        <hr />
        <footer>
            <p>&copy; @DateTime.Now.Year - My ASP.NET Application</p>
        </footer>
    </div>

    @Scripts.Render("~/bundles/jquery")
    @Scripts.Render("~/bundles/bootstrap")
    @RenderSection("scripts", required:=False)
</body>
</html>
