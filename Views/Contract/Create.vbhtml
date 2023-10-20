@ModelType RentAVehicle.ContractModels
@Code
    ViewData("Title") = "Create Contract"
End Code

<h2>Create Contract</h2>

<hr />
@Using (Html.BeginForm())
    @Html.AntiForgeryToken()

    @<div class="form-horizontal">
        @Html.ValidationSummary(True, "", New With {.class = "text-danger"})
        <div class="form-group">
            @Html.LabelFor(Function(model) model.UserName, "Name", htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.UserName, New With {.htmlAttributes = New With {.class = "form-control", .required = True}})
                @Html.ValidationMessageFor(Function(model) model.UserName, "", New With {.class = "text-danger"})
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.IDNumber, "ID Number", htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.IDNumber, New With {.htmlAttributes = New With {.class = "form-control", .required = True}})
                @Html.ValidationMessageFor(Function(model) model.IDNumber, "", New With {.class = "text-danger"})
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.EmailAddress, "Email Address", htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.EmailAddress, New With {.htmlAttributes = New With {.class = "form-control", .type = "email", .required = True}})
                @Html.ValidationMessageFor(Function(model) model.EmailAddress, "", New With {.class = "text-danger"})
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.VehicleId, "Vehicle", htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-10">
                @Html.DropDownList("VehicleId", Nothing, htmlAttributes:=New With {.class = "form-control", .required = True})
                @Html.ValidationMessageFor(Function(model) model.VehicleId, "", New With {.class = "text-danger"})
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.ValidFrom, "From", htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.ValidFrom, New With {.htmlAttributes = New With {.class = "form-control", .type = "datetime-local", .required = True}})
                @Html.ValidationMessageFor(Function(model) model.ValidFrom, "", New With {.class = "text-danger"})
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.ValidTo, "To", htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.ValidTo, New With {.htmlAttributes = New With {.class = "form-control", .type = "datetime-local", .required = True}})
                @Html.ValidationMessageFor(Function(model) model.ValidTo, "", New With {.class = "text-danger"})
            </div>
        </div>

        <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <input type="submit" value="Create" class="btn btn-default" />
            </div>
        </div>
    </div>  End Using

<div>
    @Html.ActionLink("Back to List", "Index")
</div>

@Section Scripts
    @Scripts.Render("~/bundles/jqueryval")
End Section
