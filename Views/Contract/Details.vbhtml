@ModelType RentAVehicle.ContractModels
@Code
    ViewData("Title") = "Contract Details"
End Code

<h2>Contract Details</h2>

<hr />
<div>
    <dl class="dl-horizontal">
        <dt>
            Vehicle
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.VehicleModels.Name)
        </dd>

        <dt>
            Name
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.UserName)
        </dd>

        <dt>
            ID Number
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.IDNumber)
        </dd>

        <dt>
            Email Address
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.EmailAddress)
        </dd>

        <dt>
            Cost Per Day
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.CostPerDay)
        </dd>

        <dt>
            From
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.ValidFrom)
        </dd>

        <dt>
            To
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.ValidTo)
        </dd>

        <dt>
            Total Amount
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.TotalAmount)
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
