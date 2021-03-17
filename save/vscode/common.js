function func1()
{
    var domArr = document.getElementsByName("inp1");

    if(domArr.length == 0)
        return;

    var dom = domArr[0];
    var val = dom.nodeValue;
    alert(val);
}

function func2()
{
    var domArr = document.getElementsByName("inp1");

    if(domArr.length == 0)
        return;
    
    var dom = domArr[0]
    var val = dom.nodeValue;

    var domArr1 = document.getElementsByTagName("div");

    var container = domArr1[0];
    var newDom = document.createElement("p");

    container.append(nerDom);
}

function func3()
{
    var domArr = document.getElementsByName("inp1");

    if(domArr.length == 0)
        return;
    
    var dom = domArr[0]
    var val = dom.nodeValue;

    // var domArr1 = document.getElementsByTagName("div");

    // var container = domArr1[0];
    var container = document.getElementById("id1");
    if (!container)
        return

    var newDom = document.createElement("p");

    newDom.innerHTML = val;
    container.append(newDom);

}

var arr1 = ["Paragraph1", "Paragraph2"]
var arr2 = [{UserName: "Da", Age:"15", SEX:"Female"},{UserName: "ni", Age:"16", SEX:"Female"},{UserName: "el", Age:"17", SEX:"Male"}]

var id2Container = document.getElementById("id2");

if(!id2Container)
{
    for (var i = 0; i< arr1.length ; i++)
    {
        // id2Container.innerHTML = "<p>" + arr1[i] + "</p>";
    }
    // id2Container.innerHTML = "<span>123</span><span>456</span>"
}