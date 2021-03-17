$(document).ready(function () {
    $("#btn1").click(function () {
        var name1 = $("#inpName").val();
        var age1 = $("#inpAge").val();
        var sex1 = $("#inpSex").val();

        //alert(name + ";" + age + ";" + sex); //顯示輸入

        $.ajax({
            url: "API/UserHandler.ashx",
            data: { "name": name1, "age": age1, "sex": sex1 , "action": "create"},
            type: "POST",
            dataType: 'json',
        })
            .done(function (data) {
                var outputText = JSON.stringify(data);
                $("#divContainer").empty();
                $('#divContainer').append("<p>" + outputText + "</p>");
            })
    });
});