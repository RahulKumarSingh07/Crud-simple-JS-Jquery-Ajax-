$(document).ready(function () {
    $("#userdetails").DataTable({
        "processing": false,
        "serverSide": false,
        "filter": true,//for search
        "orderMulti": false,
        "ajax": {
            "url": "User/GetUser",
            "type": "POST",
            "datatype": "json"
        },
       
               "columns": [
                { "data": "Id","name":"Id", "autowidth": true },
                { "data":"Name","name": "Name", "autowidth": true },
                { "data": "Gender","name":"Gender", "autowidth": true },
                { "data":"Mobile_No","name": "Mobile_No", "autowidth": true },
                { "data": "Email_Id","name":"Email_Id", "autowidth": true },
                { "data":"Address","name": "Address", "autowidth": true },
                {

                    "render": function (data, type, full, meta) {
                        return "<a href='#' class='btn btn-secondary'onclick=EditUser('" + full.Id + "'); >Edit</a>&nbsp;&nbsp;<a id='del' class='btn btn-danger' onclick=DeUser('" + full.Id + "'); >Delete</a>"

                    }
                }
        ],
        


    });

 
 
});

function EditUser(Id) {

    alert("Edit "+Id);
}
function DeUser(Id) {

    alert("delete  " + Id);
}
   




$(function () {
  
    var pp = $("#popup");
    $('button[data-toggle="modal"]').click(function (event) {
        var url = $(this).data('url');
        $.get(url).done(function (data) {
            pp.html(data);
            pp.find('.modal').modal('show');

        });
    });
});