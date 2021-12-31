$(document).ready(function () {



    var count = 0;
    //   totalAmount = 0,
    //   recordAmount = 0,
    //   balanceAmount = 0;

    //var DataVel = new Object(),
    //      testt = new Object(),
    //      payment = {}




    //record = {
    //    records: []
    //};

    //var form = {
    //    record,
    //    payment
    //}

    $("#records").DataTable({

        ajax: {
            url: "/api/records/daily",
            method: "Get",
            dataType: "json",
            dataSrc: ""
        },

        columns: [
            {

                data: "",
                render(data) {
                    return '<b>' + ++count + '</b>'
                }
            },
            {
                data: "dateAdded"

            },
            {
                data: "type"

            },
            {
                data: "quantity",
                render(data) {
                    return '<b>' + data.reams + '</b>' + " Reams " + '<b>' + data.sheets + '</b>' + " Sheets"
                }

            },
             {
                 data: "item"

             },
              {
                  data: "isDamaged",
                  //render(data) {
                  //    return '<b>' + data.reams + '</b>' + " Reams " + '<b>' + data.sheets + '</b>' + " Sheets"
                  //}

              },
              {
                  data: "balance",
                  render(data) {
                      return '<b>' + data.reams + '</b>' + " Reams " + '<b>' + data.sheets + '</b>' + " Sheets"
                  }

              },

              {
                  data: "destination"

              },
               {
                   data: "staffNo"

               }
        ]
    });

    //$('#newrecord').on("click", function (e) {


    //    e.preventDefault();


    //    


    //    var record =
    //        {
    //            typeId: $("#types").val(),
    //            itemId: $("#items").val(),
    //            isDamaged: $('#isdamaged').val()
    //        };

    //    record.quantity = {
    //        reams: $("#reams").val(),
    //        sheets: $("#sheets").val(),
    //    };



    //    $.ajax({
    //        url: "/api/records/new",
    //        method: "POST",
    //        dataType: "json",
    //        data: record,


    //        success: function (d) {
    //            DisplayRecord(d);





    //        },
    //        error: function () {
    //            alert("Error please try again");
    //        }

    //    });


    //    function DisplayRecord(response) {



    //        var Data = response


    //        if (Data != null) {


    //            $("#records").prepend(

    //              $('<tr role="row"><td> <i> Added </i> </td><td>' + Data.dateAdded + '</td><td>' + Data.type + '</td><td><b>' + Data.quantity.reams + '</b> Reams <b>' + Data.quantity.sheets + '</b> Sheets</td><td>' + Data.item + '</td><td>' + Data.isDamaged + '</td><td><b>' + Data.balance.reams + '</b> Reams <b>' + Data.balance.sheets + '</b> Sheets</td><td>' + Data.destination + '</td><td></td></tr>'));

    //            $('#recordform').trigger("reset");

    //            //  $('#recordmodal').css("display", "none");


    //            if ($('#recordmodal').css("display", "none")) {
    //                alert("Saved Successfully");
    //            }




    //        }







    //    }

    //});






    //$('#cusaddrecord').on("click", function (e) {


    //    e.preventDefault();



    //    

    //    var record =
    //        {
    //            typeId: $("#types1").val(),
    //            itemId: $("#items1").val(),
    //            isDamaged: $("#isdamaged1").val(),
    //            amount: $("#amount").val()
    //        };

    //    record.quantity = {
    //        reams: $("#reams1").val(),
    //        sheets: $("#sheets1").val(),
    //    };




    //    if (record.typeId != null && record.typeId != "" && record.itemId != null && record.itemId != "" && (record.quantity.reams >> 0 || record.quantity.sheets >> 0)) {

    //        if (form.record.records.push(record)) {
    //            DisplayRecord(record)



    //            totalAmount = parseFloat($("#total").val()) || 0;
    //            recordAmount = parseFloat(record.amount) || 0;
    //            balanceAmount = parseFloat($("#balance").val()) || 0;
    //            var bal = balanceAmount;


    //            totalAmount += recordAmount;

    //            $("#total").val(totalAmount);

    //            var type = parseFloat(record.typeId) || 0;



    //            if (type === 1) {
    //                $('#balance').val(balanceAmount + totalAmount);
    //            }





    //            if (type === 2) {
    //                $('#balance').val(balanceAmount - totalAmount);

    //            }
    //            //balanceAmount -= totalAmount;


    //            //if ($('#balance').val() < 0) {
    //            //    $('#balance').val().fontcolor("red");
    //            //}


    //            $('#balance').val(balanceAmount);

    //            //  if ($('#balance').val() < 0) {
    //            //      //$('#balance').val().fontcolor("red");
    //            //      // $('#cusrecordform').css("display", "none");

    //            //      $('#balance').css("font", "red");

    //            //}
    //        }
    //    }
    //    else {
    //        alert("check your entries");
    //    }





    //    function DisplayRecord(response) {



    //        var Data = response


    //        if (Data != null) {


    //            $("#cusrecord").prepend(

    //              $('<tr role="row" id="new" name="new" ><td ><i>Selected</i>  </td><td>' + testt.name + '</td><td><span style="display: inline-table;     width: 40%;">' + Data.quantity.reams + '<b> Reams </b></span><span style="display: inline-table;  margin-left:5px;  width: 40%;">' + Data.quantity.sheets + '<b> Sheets </b></span></td><td>' + Data.isDamaged + '</td><td><span style="display: inline-table;     width: 40%;"></span> <span style="display: inline-table; margin-left:5px;   width: 40%;"></span></td><td>' + Data.amount + '</td>     </tr>'));


    //            $("#items1").val("");
    //            $("#amount").val("");



    //        }







    //    }

    //});


    //
    //$('#newcusrecord').on("click", function (e) {


    //    e.preventDefault();


    //    
    //    form.record.recordDetails = {
    //        personId: $("#persons").val(),
    //        receiptId: $("#receipts").val(),
    //        receiptNumber: $("#receiptnum").val()

    //    };





    //    form.payment = {
    //        personId: $("#persons").val(),
    //        modeId: $("#modes").val(),
    //        amount: $("#payamount").val(),
    //        ref: $("#payref").val(),
    //        accountId: $("#accounts").val(),
    //        typeId: $("#types2").val()
    //    }


    //    

    //    if (form.payment.modeId > 0 || form.payment.amount > 0 || form.payment.ref != null || form.payment.accountId > 0 || form.payment.typeId > 0) {
    //        if (form.payment.modeId > 0 && form.payment.amount > 0 && form.payment.amount != "" && form.payment.ref != null && form.payment.ref != "" && form.payment.accountId > 0 && form.payment.typeId > 0) {


    //            AddPersonRecord(form);

    //        }
    //        else {
    //            alert("Check Payment Entries");
    //        }
    //    }
    //    else {
    //        AddPersonRecord(form);
    //    }



































    //    //$.each(personrecords.records, function (i, _record) {

    //    //    _record.typeId = $("#types1").val();

    //    //});








    //});




    //function AddPersonRecord(form) {
    //    $.ajax({
    //        url: "/api/records/personrecords",
    //        method: "POST",
    //        dataType: "json",
    //        data: form,


    //        success: function (d) {



    //            DisplayRecord(d);





    //        },
    //        error: function () {
    //            alert("Error please try again");
    //        }

    //    });


    //    function DisplayRecord(response) {



    //        var Data = response



    //        if (Data != null) {


    //            var DataLength = Data.length;

    //            if (DataLength >> 0) {


    //                $.each(Data, function (i, output) {

    //                    $("#records").prepend(

    //              $('<tr role="row"><td> <i> Added </i> </td><td>' + output.dateAdded + '</td><td>' + output.type + '</td><td><b>' + output.quantity.reams + '</b> Reams <b>' + output.quantity.sheets + '</b> Sheets</td><td>' + output.item + '</td><td>' + output.isDamaged + '</td><td><b>' + output.balance.reams + '</b> Reams <b>' + output.balance.sheets + '</b> Sheets</td><td>' + output.destination + '</td><td></td></tr>'));

    //                });


    //            }


    //            $('#cusbody').children("tr").remove();

    //            $('#cusrecordform').trigger("reset");


    //            // $('#cusrecordform').css("display", "none");



    //            if ($('#cusrecordmodal').hide()) {
    //                alert("Saved Successfully");
    //            }



    //        }








    //    }
    //}


    //var shares = ['items', 'persons', 'receipts', 'banks']


    //$.each(shares, function (i, share) {

    //    var route = share.toString();

    //    $.ajax({
    //        url: "/api/shared/" + route,
    //        method: "Get",
    //        dataType: "json",
    //        data: "{}",

    //        success: function (data) {
    //            DisplayDropDown(data);
    //        },
    //        error: function () {
    //            alert("Please reload browser")
    //        }

    //    });

    //    function DisplayDropDown(response) {



    //        var Data = response;

    //        var DataLength = Data.length;

    //        if (DataLength >> 0) {


    //            $("#" + route).html("");

    //            $("#" + route).html("<option value=''></option>");

    //            var rou = route + "1";

    //            var rouu = route + "2";


    //            $("#" + rou).html("");

    //            $("#" + rou).html("<option value=''></option>");

    //            $.each(Data, function (i, output) {

    //                $("#" + route).append(
    //                    $('<option></option>').val(output.id).html(output.name));

    //                $("#" + rou).append(
    //                    $('<option></option>').val(output.id).html(output.name));

    //                $("#" + rouu).append(
    //                   $('<option></option>').val(output.id).html(output.name));



    //            });





    //            if (route === 'persons') {

    //                var DataVal = Data;


    //                var $select1 = $('#persons'),
    //                    $value1 = $('#balance');



    //                $select1.on('change', DataVal, function (output) {


    //                    if (this.value >> 0) {
    //                        var ind = parseFloat(this.value);


    //                        var test = output[ind];

    //                        $.each(DataVal, function (i, output) {
    //                            if (output.id === ind)
    //                                test = output;

    //                        });






    //                        $value1.val(test.balance);
    //                        // $value1.html($option.filter('[value = "' + this.value + '"]'));

    //                    }



    //                }).trigger('change');

    //            }











    //            if (rou === 'items1' || route === 'items') {



    //                DataVel = Data;

    //                var $select2 = $('#items1'),
    //                    $select2i = $('#items'),
    //                    $value21 = $('#breams'),
    //                    $value21i = $('#breamsi'),
    //                    $value22 = $('#bsheets'),
    //                    $value22i = $('#bsheetsi');




    //                $select2.on('change', DataVel, function (outputt) {

    //                    if (this.value >> 0) {
    //                        var indexx = parseFloat(this.value);

    //                        testt = outputt[indexx];


    //                        $.each(DataVel, function (i, outputt) {
    //                            if (outputt.id === indexx)
    //                                testt = outputt;

    //                        });

    //                        $value21.val(testt.balance.reams);
    //                        $value22.val(testt.balance.sheets);


    //                    }
    //                }).trigger('change');






    //                $select2i.on('change', DataVel, function (outputt) {

    //                    if (this.value >> 0) {
    //                        var indexx = parseFloat(this.value);

    //                        testt = outputt[indexx];


    //                        $.each(DataVel, function (i, outputt) {
    //                            if (outputt.id === indexx)
    //                                testt = outputt;

    //                        });

    //                        $value21i.val(testt.balance.reams);
    //                        $value22i.val(testt.balance.sheets);


    //                    }
    //                }).trigger('change');




    //            }





    //        }


    //    }


    //});




    $.ajax({
        url: "/api/shared/enums",
        method: "Get",
        dataType: "json",
        data: "{}",

        success: function (data) {
            DisplayEnums(data);
        },
        error: function () {
            alert("Please reload browser")
        }

    });

    function DisplayEnums(response) {



        var Data = response.stockTypes;

        var DataLength = Data.length;

        if (DataLength > 0) {


            $("#types").html("");

            $("#types").html("<option value=''></option>");


            $("#types1").html("");

            $("#types1").html("<option value=''></option>");


            $("#types2").html("");

            $("#types2").html("<option value=''></option>");



            $.each(Data, function (i, _output) {

                $("#types").append(
                    $('<option></option>').val(++i).html(_output));

                $("#types1").append(
                   $('<option></option>').val(i).html(_output));

                $("#types2").append(
                   $('<option></option>').val(i).html(_output));


            });
        }


    }





    var amtpaid = 0,
        bal = 0,
        person=0,
        type = 0;

    
    $("#amtpaid, #bal2").keyup(function () {
        
        amtpaid = parseFloat($("#amtpaid").val()) || 0;
        bal = parseFloat($("#bal2").val()) || 0;
        type = parseFloat($("#types2").val()) || 0;
        person = parseFloat($("#persons2").val()) || 0;



        if (person === 0) {
            alert("Please select a customer/dealer first");
            $("#amtpaid").val(0);
        }

       else if (type === 0) {
            alert("Please select a type first");
            $("#amtpaid").val(0);
        }
        else {
            if (type === 1) {
                $("#bal2").val(bal + amtpaid);
            }

            if (type === 2) {
                $("#bal2").val(bal - amtpaid);
            }
        }

       





    });

   



    //var $select123 = $('#persons2');
                      
    //$select123.on('change', function () {


    //    
    //    amtpaid = 0;
       
    //    type =  0;

       




    //}).trigger('change');




    //var $select1234 = $('#types2');

    //$select1234.on('change', function () {


    //    
    //    amtpaid = 0;
        

    //}).trigger('change');
















});