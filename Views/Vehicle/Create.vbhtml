@ModelType RentAVehicle.VehicleModels
@Code
    ViewData("Title") = "Create Vehicle"
End Code

<h2>Create Vehicle</h2>

<hr />
@Using (Html.BeginForm())
    @Html.AntiForgeryToken()

    @<div class="form-horizontal">
        @Html.ValidationSummary(True, "", New With {.class = "text-danger"})
        <div class="form-group">
            @Html.LabelFor(Function(model) model.Name, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.Name, New With {.htmlAttributes = New With {.class = "form-control", .required = True}})
                @Html.ValidationMessageFor(Function(model) model.Name, "", New With {.class = "text-danger"})
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.Type, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.Type, New With {.htmlAttributes = New With {.class = "form-control", .required = True}})
                @Html.ValidationMessageFor(Function(model) model.Type, "", New With {.class = "text-danger"})
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.Model, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.Model, New With {.htmlAttributes = New With {.class = "form-control", .required = True}})
                @Html.ValidationMessageFor(Function(model) model.Model, "", New With {.class = "text-danger"})
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.Year, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.Year, New With {.htmlAttributes = New With {.class = "form-control", .required = True}})
                @Html.ValidationMessageFor(Function(model) model.Year, "", New With {.class = "text-danger"})
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.CostPerDay, "Cost Per Day", htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.CostPerDay, New With {.htmlAttributes = New With {.class = "form-control", .required = True}})
                @Html.ValidationMessageFor(Function(model) model.CostPerDay, "", New With {.class = "text-danger"})
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.Availability, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-10">
                <div class="checkbox">
                    @Html.EditorFor(Function(model) model.Availability)
                    @Html.ValidationMessageFor(Function(model) model.Availability, "", New With {.class = "text-danger"})
                </div>
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
