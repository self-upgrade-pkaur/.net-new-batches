console.log('Hello World');
/*window.onload=function(){
    debugger;
    var url='https://localhost:44304/api/contact';
    if (window.XMLHttpRequest) { // Mozilla, Safari, IE7+ ...
        httpRequest = new XMLHttpRequest();
    } 
    else if (window.ActiveXObject) { // IE 6 and older
        httpRequest = new ActiveXObject("Microsoft.XMLHTTP");
    }
    httpRequest.onreadystatechange=function(){
        console.log(httpRequest.status+'-'+httpRequest.readyState)
        //process response
        var contacts=JSON.parse(httpRequest.response);
        console.log(typeof(contacts));
        var tbody=document.getElementById("cbody");
    contacts.forEach(contact => {
        debugger;
        var tr=document.createElement("tr");
        var td1=document.createElement("td");
        td1.innerHTML=contact.firstName+' '+contact.lastName;
        tr.appendChild(td1);
        var td2=document.createElement("td");
        td2.innerHTML=contact.mobile
        tr.appendChild(td2);
        tbody.appendChild(tr);
        contact.firstname
    });
    }
    httpRequest.open('GET',url,true);
    httpRequest.send();
};*/