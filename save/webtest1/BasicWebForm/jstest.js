function func1() {
    var domArr = document.getElementsByName("inp1");

    if (domArr.length == 0)
        return;

    var dom = domArr[0];

    var val = dom.value;
    alert(val);
}



function func2() {
    var domArr = document.getElementsByName("inp1");

    if (domArr.length == 0)
        return;

    var dom = domArr[0]
    var val = dom.value;

    var domArr1 = document.getElementsByTagName("div");

    var container = domArr1[0];
    var newDom = document.createElement("p");
    newDom.innerText = val;
    container.append(newDom);
}

function func3()
{
    //var domArr = document.getElementsByName("inp1");

    //if (domArr.length == 0)
    //    return;

    //var dom = domArr[0]
    //var val = dom.nodeValue;

    //// var domArr1 = document.getElementsByTagName("div");

    //// var container = domArr1[0];
    //var container = document.getElementById("id1");
    //if (!container)
    //    return

    //var newDom = document.createElement("p");

    //newDom.innerHTML = val;
    //container.append(newDom);

    //var arr1 = ["Paragraph1", "Paragraph2"]
    //var arr2 = [{ UserName: "John", Age: 17, Sex: "Female" }, { UserName: "Mary", Age: 16, Sex: "Female" }, { UserName: "Johnny", Age: 18, Sex: "Male" }]

    function init()
    {
        var id2Container = document.getElementById("id2");

        if (id2Container) {
            //{
            //for (var i = 0; i < arr1.length; i++) {
            //    // id2Container.innerHTML = "<p>" + arr1[i] + "</p>";
            //}

            for (var i = 0; i < arr2.length; i++) {
                id2Container.innerHTML += "<p><span>" + arr2[i].UserName + "</span><span>" + arr2[i].Age + "</sapn><span>" + arr2[i].Sex + "</span></p>"
            }
            // id2Container.innerHTML = "<span>123</span><span>456</span>"
        }
    }

}
//init(); //自動執行一次

function inpKeyUp_KeyUp()
{
    var inp = document.getElementById("inpKeyUp");

    if (!inp)
        return;
    
    var txt = inp.value;
    txt = txt.toUpperCase();
    inp.value = txt;
}

//function func1() {
//    var domArr = document.getElementsByName("inp1");

//    if (domArr.length == 0)
//        return;

//    var dom = domArr[0]

//    var val = dom.value;
//    alert(val);
//}


//function func2()
//{
//    var domArr = document.getElementsByName("inp1");

//    if (domArr.length == 0)
//        return;

//    var dom = domArr[0]
//    var val = dom.value;

//    var domArr1 = document.getElementsByName("dss");

//    var container = domArr1[0];
//    var newDom = document.createElement("p");
//    newDom.innerText = val;
//    container.append(newDom);

//}

//function func3() {
//    //var domArr = document.getElementsByName("inp1");

//    //if (domArr.length == 0)
//    //    return;

//    //var dom = domArr[0]
//    //var val = dom.value;

//    ////var domArr1 = document.getElementsByTagName("div"); //

//    ////var container = domArr1[0]; //

//    //var container = document.getElementById("id1");

//    //if (!container)
//    //    return;


//    //var newDom = document.createElement("p");

//    //newDom.innerHTML = val;
//    //container.append(newDom);

//    //var arr1 = ["Paragraph 1", "Paragraph 2"];
//    //var arr2 = [{
//    //    UserName: "John", Age: 17, Sex: "Male"
//    //},
//    //{ UserName: "Mary", Age: 17, Sex: "Female" },
//    //{ UserName: "Johnny", Age: 17, Sex: "Male" }]

//    var id2Container = document.getElementById("id2")

//    if (id2Container) {
//        for (var i = 0; i < arr2.length; i++) {

//            id2Container.innerHTML += "<p><span>" + arr2[i].UserName + "</span><span>" +
//                arr2[i].Age + "</span><span>" + arr2[i].Sex + "</span></p>";


//            /*id2Container.innerHTML = "<p>" + arr1*/
//        }
//        /*    id2Container.innerHTML = "<span>123456</span>"*/
//    }

//}

