$(document).ready(function () {

    $("#btn1").click(function () {
        var name1 = $("#inpName").val();

        $.ajax({
            //url: '/API/Sample.json',
            url: "API/QueryUser.ashx",
            //data: { id: 'pekora' },
            data:{ "name": name1 },
            //type: 'GET',
            type: "GET",
            dataType: 'json',
        })
        //beforeSend: function (xhr) {
        //    xhr.overrideMimeType("text/plain; charset=x-user-defined");
        //}
        //.done(function (jsonArr) {
        .done(function (data) {
            //for (var i = 0; i < jsonArr.length; i++) {
            //    var html = "<p><span>" +
            //        jsonArr[i].UserName + "</span><span>" +
            //        jsonArr[i].Age + "</span><span>" +
            //        jsonArr[i].Sex + "</span></p>";
            var outputText = JSON.stringify(data);
            $("#divContainer").empty();
            $('#divContainer').append("<p>" + outputText + "</p>");
            //$('#divContainer').append(html);
                //$("body").append(html);
        })
        //.done(function (json) {
        //    var outputText = JSON.stringify(json);
        //    //$("body").append("<p>" + data + "</p>");
        //    $("body").append("<p>" + outputText + "</p>");
        //})
        .fail(function (xhr, status, errorThrown) {
            console.log('好油喔，無法完成');
            console.log('Error:' + errorThrown);
            console.log('Status:' + status);
            console.dir(xhr);
        })
        .always(function (xhr, status) {
            console.log('要求已完成!');
        })
    //.done(function (data) {
    //    //console.log(data);
    //    //if (console && console.log) {
    //    //    console.log("Sample of data:", data.slice(0, 100));
    //    //}
    //    var outputText = JSON.stringify(data);
    //    //$("body").append("<p>" + data + "</p>");
    //    $("body").append("<p>" + outputText + "</p>");
    //})
    //.fail(function () {
    //    console.log("傳輸失敗");
    //    });
    });
});