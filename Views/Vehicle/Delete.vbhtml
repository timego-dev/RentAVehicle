@ModelType RentAVehicle.VehicleModels
@Code
    ViewData("Title") = "Delete Vehicle"
End Code

<h2>Delete Vehicle</h2>

<h4>Are you sure you want to delete this?</h4>

<hr />
<div>
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.Name)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Name)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Type)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Type)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Model)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Model)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Year)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Year)
        </dd>

        <dt>
            Cost Per Day
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.CostPerDay)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Availability)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Availability)
        </dd>

    </dl>
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
            <input type="submit" value="Delete" class="btn btn-default" /> |
            @Html.ActionLink("Back to List", "Index")
        </div>
    End Using
</div>
