$(document).ready(function () {







    var paymentresource = {};



    debugger;
    $('#newpay').on("click", function (e) {


        e.preventDefault();


        debugger;

        paymentresource = {
            personId: $("#persons2").val(),
            modeId: $("#modes2").val(),
            amount: $("#amtpaid").val(),
            ref: $("#payref2").val(),
            accountId: $("#banks").val(),
            type: $("#types2").val()

        };






        debugger;
        $.ajax({
            url: "/api/payments/add",
            method: "POST",
            dataType: "json",
            data: paymentresource,


            success: function (d) {


                debugger;
                DisplayRecord(d);



            },
            error: function () {
                debugger;
                alert("Error please try again");
            }

        });



        function DisplayRecord(response) {

            debugger;
            if (Data != null) {         

                $('#personform').trigger("reset");


                // $('#cusrecordform').css("display", "none");


                if ($('#personform').hide()) {
                    alert("Saved Successfully");
                }



            }



        }

    });










});