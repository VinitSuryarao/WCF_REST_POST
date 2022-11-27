function getAllClients() {
    $.ajax({
        url: "Service/ClientService.svc/GetAllClients",
        type: "GET",
        dataType: "json",
        success: function (result) {
            clients = result;
            bindClientListToTable(clients);
        }
    });
}


function addClient(){
    var client = {
        "Id": $("#addId").val(),
        "Code": $("#addCode").val(),
        "Name": $("#addName").val(),
        "Exchange": $("#addExchange").val()
    };

    $.ajax({
        url: "Service/ClientService.svc/AddClient",
        type: "POST",
        dataType: "json",
        contentType: "application/json",
        data: JSON.stringify(client),
        success: function (result) {
            getAllClients();
        }
    });
}

