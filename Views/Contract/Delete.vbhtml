@ModelType RentAVehicle.ContractModels
@Code
    ViewData("Title") = "Delete Contract"
End Code

<h2>Delete Contract</h2>

<h4>Are you sure you want to delete this?</h4>

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
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
            <input type="submit" value="Delete" class="btn btn-default" /> |
            @Html.ActionLink("Back to List", "Index")
        </div>
    End Using
</div>
