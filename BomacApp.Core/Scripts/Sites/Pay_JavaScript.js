//Get the modal
var paymodal = document.getElementById('paymodal');


//Get the button that opens the modal
var paybtn = document.getElementById('addpayment');

//Get the <span> element that closes the modal
var payclosespan = document.getElementsByClassName('close')[2];


//Get button element that closes the modal
var payclosemodal = document.getElementsByClassName('closemodal')[2];


//when the user click on the button, open the model
paybtn.onclick = function(){
    paymodal.style.display = "block";
}


//When the user clicks on <span> (x), close the modal

payclosespan.onclick = function () {
    paymodal.style.display = "none";
}

//When the user clicks on <button> (close), close the modal
payclosemodal.onclick = function () {
    paymodal.style.display = "none";
}
