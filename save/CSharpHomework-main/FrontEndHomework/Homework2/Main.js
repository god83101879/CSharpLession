$(document).ready(function () { //這個函式是用來取代頁面中的window.onload 類似page_load 如果沒有此函式網頁會直接順序從上往下讀取;

    $("#btn1").click(function () {
        var inputArr = document.getElementsByTagName("input");
        var textareaArr = document.getElementsByTagName("textarea");

        var domNickname, domTitle;
        var domMessage = textareaArr[0];

        for (var i = 0; i < inputArr.length; i++) {
            if (inputArr[i].name == "nickname")
                domNickname = inputArr[i];

            if (inputArr[i].name == "title")
                domTitle = inputArr[i];
        }

        var html =
            '<div style="border: 1px solid black;"><p>NickName: ' +
            domNickname.value + "</p><p> Time: " +
            new Date().toISOString() + "</p><p> Title: " +
            domTitle.value + "</p><p> Message: " +
            domMessage.value + "</p></div>";

        document.getElementById("divContext").innerHTML += html;
    });
});
