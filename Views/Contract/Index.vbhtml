@ModelType IEnumerable(Of RentAVehicle.ContractModels)
@Code
    ViewData("Title") = "Contracts"
End Code

<h2>Contracts</h2>

@If Request.IsAuthenticated Then
    @<p>
        @Html.ActionLink("Create New", "Create")
    </p>
End If
<table class="table">
    <tr>
        <th>
            Vehicle
        </th>
        <th>
            User Name
        </th>
        <th>
            ID Number
        </th>
        <th>
            Email Address
        </th>
        <th>
            Cost Per Day
        </th>
        <th>
            From
        </th>
        <th>
            To
        </th>
        <th>
            Total Amount
        </th>
        <th></th>
    </tr>

    @For Each item In Model
        @<tr>
            <td>
                @Html.DisplayFor(Function(modelItem) item.VehicleModels.Name)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.UserName)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.IDNumber)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.EmailAddress)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.CostPerDay)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.ValidFrom)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.ValidTo)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.TotalAmount)
            </td>
            @If Request.IsAuthenticated Then
                @<td>
                    @Html.ActionLink("Edit", "Edit", New With {.id = item.Id}) |
                    @Html.ActionLink("Details", "Details", New With {.id = item.Id}) |
                    @Html.ActionLink("Delete", "Delete", New With {.id = item.Id})
                </td>
            Else
                @<td>
                    @Html.ActionLink("Details", "Details", New With {.id = item.Id})
                </td>
            End If
        </tr>
    Next

</table>
