var clients = {};
var client = {};

function bindClientListToTable(clientList) {
    $tbody = $("#table-body");
    $tbody.empty();
    for (var i = 0; i < clientList.length; i++) {
        $tr = $("<tr>");
        $("<td>").html(clientList[i].Id).appendTo($tr);
        $("<td>").html(clientList[i].Code).appendTo($tr);
        $("<td>").html(clientList[i].Name).appendTo($tr);
        $("<td>").html(clientList[i].Exchange).appendTo($tr);
        $tbody.append($tr);
    }
}

$(document).ready(function () {
    getAllClients();
});