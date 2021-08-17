$("#lapt").click(function () {
    $.ajax({
        type: "GET",
        url: "/Computers/Index",
    }).done(function (data) {
        $("section").empty();
        $("section").append(data);
    }).fail(function () {
        alert("error");
    })
});