@ModelType IEnumerable(Of RentAVehicle.VehicleModels)
@Code
    ViewData("Title") = "Vehicles"
End Code

<h2>Vehicles</h2>

@If Request.IsAuthenticated Then
    @<p>
        @Html.ActionLink("Create New", "Create")
    </p>
End If
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.Name)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Type)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Model)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Year)
        </th>
        <th>
            Cost Per Day
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Availability)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Name)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Type)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Model)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Year)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.CostPerDay)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Availability)
        </td>
        @If Request.IsAuthenticated Then
            @<td>
                @Html.ActionLink("Edit", "Edit", New With {.id = item.Id}) |
                @Html.ActionLink("Details", "Details", New With {.id = item.Id}) |
                @Html.ActionLink("Delete", "Delete", New With {.id = item.Id})
            </td>
        Else
            @<td>
                @Html.ActionLink("Details", "Details", New With {.id = item.Id}) |
                @Html.ActionLink("Rent", "Create", "Contract", New With {.vehicleId = item.Id}, New With {.class = ""})
            </td>
        End If
    </tr>
Next

</table>
