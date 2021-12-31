//Get the model
var singlemodel = document.getElementById('singlerecordmodal');
var personmodal = document.getElementById('personmodal');



// Get the button that opens the modal 
var personbtn = document.getElementById("addperson");


//Get the <span> element that closes the model
var singleclosespan = document.getElementsByClassName("close")[0];
var personclosespan = document.getElementsByClassName("close")[1];





//Get the <buttton> element that closes the model
var singleclosemodelspan = document.getElementsByClassName("closemodal")[0];
var personclosemodelspan = document.getElementsByClassName("closemodal")[1];




// When the user clicks on the button, open the modal 
personbtn.onclick = function () {
    personmodal.style.display = "block";

}







//When the user clicks on <span> (x), close the modal
singleclosespan.onclick = function () {
    singlemodel.style.display = "none";
   
}

personclosespan.onclick = function () {
    personmodal.style.display = "none";

}


//When the user clicks on <button> (close), close the modal

singleclosemodelspan.onclick = function () {
    singlemodel.style.display = "none";

   
}

personclosemodelspan.onclick = function () {
    personmodal.style.display = "none";


}


 //When the user clicks anywhere outside of the modal, close it
window.onclick = function (event) {
    if (event.target == singlemodel) {
        singlemodel.style.display = "none";

       
    }
}

//var inp = document.getElementById('mybal');
//

//inp.onchange = function formatValue() {
   
//    var x = Number(inp.value);

//    inp.value = x.toLocaleString();
//    inp.value.
//}