var dataTable;

$(document).ready(function () {
    loadDataTable();
});

function loadDataTable() {
    dataTable = $('#tblData').DataTable({
        "ajax": { url:'/cameracontroltag/getall'},
        "columns": [
            { data: 'tagName', "width": "20%" },
            { data: 'description', "width": "15%" },
            { data: 'createdTs', "width": "20%" },
            { data: 'updatedTs', "width": "20%" },
            { data: 'camera.name', "width": "15%" },
            {
                data: 'id',
                "render": function (data) {
                    return `<div class="w-75 btn-group" role="group">
                     <a href="/cameracontroltag/upsert?id=${data}" class="btn btn-primary mx-2"> <i class="bi bi-pencil-square"></i> Edit</a>               
                     <a onClick=Delete('/cameracontroltag/delete/${data}') class="btn btn-danger mx-2"> <i class="bi bi-trash-fill"></i> Delete</a>
                    </div>`
                },
                "width": "25%"
            }
        ]
    });
    console.log(dataTable);
}

function Delete(url) {
    Swal.fire({
        title: 'Are you sure?',
        text: "You won't be able to revert this!",
        icon: 'warning',
        showCancelButton: true,
        confirmButtonColor: '#3085d6',
        cancelButtonColor: '#d33',
        confirmButtonText: 'Yes, delete it!'
    }).then((result) => {
        if (result.isConfirmed) {
            $.ajax({
                url: url,
                type: 'DELETE',
                success: function (data) {
                    dataTable.ajax.reload();
                    toastr.success(data.message);
                }
            })
        }
    })
}