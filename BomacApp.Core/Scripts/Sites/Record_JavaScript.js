// Get the modal
var modal = document.getElementById('recordmodal');
var cusmodal = document.getElementById('cusrecordmodal');







// Get the button that opens the modal
var btn = document.getElementById("addrecord");
var cusbtn = document.getElementById("addcusrecord");



// Get the <span> element that closes the modal
var closespan = document.getElementsByClassName("close")[0];
var cusclosespan = document.getElementsByClassName("close")[1];


// Get the <span> element that closes the modal
var closemodalspan = document.getElementsByClassName("closemodal")[0];
var cusclosemodalspan = document.getElementsByClassName("closemodal")[1];


// When the user clicks on the button, open the modal 
btn.onclick = function () {
    modal.style.display = "block";
   
}

cusbtn.onclick = function () {
    cusmodal.style.display = "block";

}





// When the user clicks on <span> (x), close the modal
closespan.onclick = function () {
    modal.style.display = "none";
}

cusclosespan.onclick = function () {
    cusmodal.style.display = "none";
}




// When the user clicks on <button> (close), close the modal
closemodalspan.onclick = function () {
    modal.style.display = "none";
}

cusclosemodalspan.onclick = function () {
    cusmodal.style.display = "none";
}

// When the user clicks anywhere outside of the modal, close it
//window.onclick = function (event) {
//    if (event.target == modal) {
//        modal.style.display = "none";
//    }
//}
