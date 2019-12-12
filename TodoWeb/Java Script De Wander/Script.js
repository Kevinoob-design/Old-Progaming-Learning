
function changeWidht(){

    var text =  document.getElementById ("Square").style.backgroundColor = "blue";
}

function changeHeight (){
    var text =  document.getElementById ("Square").style.height = "100px";
    
}

function highlight(){

    var ligthening = document.getElementsByTagName("p");    

    var Colors = ["blue","yellow","red","green"];

    for(var i = 0;i<=ligthening.length;i++){
        var changingColor = ligthening[i].style.backgroundColor = Colors[i];
    }
}


function backToNormal(){

    var ligthening = document.getElementsByTagName("p");    
    
        var Colors = ["","","",""];
    
        for(var i = 0;i<=ligthening.length;i++){
            var changingColor = ligthening[i].style.backgroundColor = Colors[i];
        }
    }

function texting(){

    changinText = document.getElementsByTagName("p");

    var swtiching = changinText[1].innerHTML = " New Text";

    var here = changinText[3].innerHTML;
    document.write(here);

} 


function createButton(){

    //Se busca donde se quiere agregar el elemento
    var root = document.getElementById("Square");


   //luego se crea el elemento, en este caso boton
    var btn = document.createElement("button");

    //anadiendo propiedas al boton 
    btn.style.color = "blue";
    btn.style.height = "100px";
    
    //Agregando texto al boton
    var t = document.createTextNode("no ");
    btn.appendChild(t);

    //se anade el boton,con todas sus propiedades hechas a la variable
    //que seleccionamos al principio, puede ser body, div, cualquier enbase :v
    root.appendChild(btn);
 


    
}

function eliminateButton(){

    var btn = document.getElementsByTagName("button")[5];
    var parent = btn.parentNode;

    parent.removeChild(btn);

}