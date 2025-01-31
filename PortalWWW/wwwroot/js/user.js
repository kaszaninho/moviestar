var dataTable;

$(document).ready(function () {
    loadDataTable();
});

function loadDataTable() {
    dataTable = $('#tblData').DataTable({
        "ajax": { url: '/admin/user/getall' },
        "columns": [
            { "data": "firstName" },
            { "data": "lastName" },
            { "data": "dateOfBirth" },
            { "data": "role" },
            {
                data: 'id',
                "render": function (data) {
                    return `<a asp-action="Edit" asp-route-id=${data}> Edit</a > | 
                        <a asp-action="Details" asp-route-id=${data}> Details</a > | <a asp-action="Delete" asp-route-id=${data}>Delete</a>`
                }
            }
        ]
    })
}