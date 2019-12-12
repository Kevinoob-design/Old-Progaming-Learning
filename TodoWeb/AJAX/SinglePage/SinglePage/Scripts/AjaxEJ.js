$(document).ready(function () {
    $("#botonTabla").click(function () {
        $.ajax({
            type: "POST",
            url: "Services/MyService.svc/GetUsuario",
            cache: true,
            async: false,
            data: "{}",
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (resultado) {
                var items = resultado.d;
                $.each(items, function (index, item) {
                    $("#contenido").append("<tr><td class='customertd'>" + item.Id
                        + "</td><td class='tdDatos'>" + item.Name + "</td>"
                        + "</td><td class='tdDatos'>" + item.Edad + "</td></tr>");
                });
            },
            error: function (result) {
                alert("Jodados");
            }
        });
    });
});