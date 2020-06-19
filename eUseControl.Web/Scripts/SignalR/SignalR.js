$.connection.hub.start()
    .done(function () {
        console.log("Conexiunea cu SignalR s-a creat!")
        $.connection.myHub.server.announce("Conectat!");
    })
    .fail(function () { alert("Eroare de conectare cu SignalR!!!") });

$.connection.myHub.client.announce = function (message) {

    $("#welcome - messages").append(message + "<br />");
}