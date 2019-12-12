function validateTextbox(){

   var box = document.getElementById("name");
   var box2 = document.getElementById("address");
   var box3 = document.getElementById("phone");
   var box4 = document.getElementById("email");
   
   if(box.value == "" || box2.value == "" || box3.value.length != 9 || box4.value == "" ){

        alert("No puede dejar el campo vacio");

        if(box3.value.lengh != 9){

            alert("El numero de telefono debe tener 9 digitos");

            box3.focus();
            box3.style.border = "solid 3px red";
        }
        return false;
   }

   if (confirm("All the values are going to be sent") == true) {
       
   } else {
       
        return false;
   }
}

function GoBack(){

    return true;
}