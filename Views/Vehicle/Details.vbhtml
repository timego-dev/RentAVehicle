@ModelType RentAVehicle.VehicleModels
@Code
    ViewData("Title") = "Vehicle Details"
End Code

<h2>Vehicle Details</h2>

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


        <dt>
            Available For Rent
        </dt>

        <dd>
            @ViewBag.AvailableForRent
        </dd>

    </dl>
</div>
@If Request.IsAuthenticated Then
    @<p>
        @Html.ActionLink("Edit", "Edit", New With {.id = Model.Id}) |
        @Html.ActionLink("Back to List", "Index")
    </p>
Else
    @<p>
        @Html.ActionLink("Back to List", "Index")
    </p>
End If
