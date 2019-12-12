function changeStyle(){
   
   var Parrafo = document.getElementsByClassName("Parrafo");

    Parrafo[2].style.color = "blue";

    var All = document.getElementsByTagName("p");

    Parrafo[2].innerHTML = Parrafo[0].innerHTML + Parrafo[1].innerHTML;

    for(var i = 0; i<All.length; i++){

        All[i].style.marginLeft = "100px";
    }
}

function NewImg(){

    var Image = document.getElementById("IMG").src="Cueva.jpg";

}


//this is for de Parragraph.

function NewElement(){
    
    var newElement = document.createElement("p");

    var body = document.getElementById("Cuerpo");

    body.appendChild(newElement);
    
    var text = document.createTextNode("New fucking text :D");

    newElement.appendChild(text);
}

// this is for remove
function Remove(){

    var newElement = document.getElementsByTagName("p")[0];

    var parent = newElement.parentNode;

    parent.removeChild(newElement);

}

