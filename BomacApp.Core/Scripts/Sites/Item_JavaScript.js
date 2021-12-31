// Get the modal
var modal = document.getElementById('categorymodal');
var itemmodal = document.getElementById('itemmodal');


// Get the button that opens the modal
var btn = document.getElementById("addcategory");
var itembtn = document.getElementById("additem");


// Get the <span> element that closes the modal
var closespan = document.getElementsByClassName("close")[0];
var itemclosespan = document.getElementsByClassName("close")[1];


// Get the <span> element that closes the modal
var closemodalspan = document.getElementsByClassName("closemodal")[0];
var itemclosemodalspan = document.getElementsByClassName("closemodal")[1];


// When the user clicks on the button, open the modal 
btn.onclick = function () {
    modal.style.display = "block";

}

itembtn.onclick = function () {
    itemmodal.style.display = "block";

}


// When the user clicks on <span> (x), close the modal
closespan.onclick = function () {
    modal.style.display = "none";
}

itemclosespan.onclick = function () {
    itemmodal.style.display = "none";
}



// When the user clicks on <button> (close), close the modal
closemodalspan.onclick = function () {
    modal.style.display = "none";
}

itemclosemodalspan.onclick = function () {
    itemmodal.style.display = "none";
}
