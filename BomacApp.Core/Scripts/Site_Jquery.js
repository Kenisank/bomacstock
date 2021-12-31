

$(document).ready(function () {






    var count = 0;

    var DataVel = new Object(),
        testt = new Object(),
        BankData = new Object();


    personrecords = {
        records: []
    };


  personformresource = {
        
    };





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


    $("#allrecords").DataTable({

        ajax: {
            url: "/api/records/",
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



    //var personcount = 0;

    //$("#personstable").DataTable({

    //    ajax: {
    //        url: "/api/persons/all",
    //        method: "Get",
    //        dataType: "json",
    //        dataSrc: ""
    //    },

    //    columns: [
    //        {

    //            data: "",
    //            render(data) {
    //                return '<b>' + ++personcount + '</b>'
    //            }
    //        },
    //        {
    //            data: "name"

    //        },
    //        {
    //            data: "uniqueNo"

    //        },

    //        {
    //            data: "contact",
    //            render(data) {
    //                return '<b>' + data.pPhoneNo + '</b>'
    //            }

    //        },
    //        {
    //            data: "state",


    //        },
    //        {
    //            data: "balance",
    //            render(data) {
    //                return '<b><i>#</i></b><b>' + data + '</b>'
    //            }

    //        },

    //        {
    //            data: "lastRecord"

    //        }

    //    ]
    //});














    var categorycount = 0;

    $("#stockcategories").DataTable({

        ajax: {
            url: "/api/shared/allcategories",
            method: "Get",
            dataType: "json",
            dataSrc: ""
        },

        columns: [
            {

                data: "",
                render(data) {
                    return '<b>' + ++categorycount + '</b>'
                }
            },
            {
                data: "name"

            },
            {
                data: "items",
                render(data) {
                    return '<b style="padding: 8px; background: #428bca; color: white; border-radius: 50% 50%; text-align: center;">' + data + '</b>'

                }

            }


        ]
    });





    var itemcount = 0;
    
    $("#stockitems").DataTable({

        ajax: {
            url: "/api/shared/items",
            method: "Get",
            dataType: "json",
            dataSrc: ""
        },

        columns: [
            {

                data: "",
                render(data) {
                    return '<b>' + ++itemcount + '</b>'
                }
            },
            {
                data: "name"

            },
            {
                data: "balance",
                render(data) {
                    return '<b>' + data.reams + '</b>' + " Reams " + '<b>' + data.sheets + '</b>' + " Sheets"
                }

            }
          
        ]
    });










   
    var shares = ['items', 'persons', 'receipts', 'modes', 'banks', 'accounts', 'categories', 'states']


    $.each(shares, function (i, share) {
        
        var route = share.toString();
        
        $.ajax({
            url: "/api/shared/" + route,
            method: "Get",
            dataType: "json",
            data: "{}",

            success: function (data) {
                DisplayDropDown(data);
            },
            error: function () {
                alert("Please reload browser")
            }

        });

        function DisplayDropDown(response) {



            var Data = response;

            var DataLength = Data.length;

            if (DataLength >> 0) {


                $("#" + route).html("");

                $("#" + route).html("<option value=''></option>");

                var rou1 = route + "1";

                var rou2 = route + "2";



                $("#" + rou1).html("");

                $("#" + rou1).html("<option value=''></option>");



                $("#" + rou2).html("");

                $("#" + rou2).html("<option value=''></option>");


                $.each(Data, function (i, output) {

                    $("#" + route).append(
                        $('<option></option>').val(output.id).html(output.name));

                    $("#" + rou1).append(
                        $('<option></option>').val(output.id).html(output.name));

                    $("#" + rou2).append(
                        $('<option></option>').val(output.id).html(output.name));



                });





                if (rou2 === 'persons2' || route === 'persons') {

                    var DataVal = Data;


                    var $select1 = $('#persons'),
                        $value1 = $('#balance'),
                        $selectp2 = $('#persons2'),
                        $valuep2 = $('#bal2');



                    $select1.on('change', DataVal, function (output) {


                        if (this.value >> 0) {
                            var ind = parseFloat(this.value);


                            var test = output[ind];

                            $.each(DataVal, function (i, output) {
                                if (output.id === ind)
                                    test = output;

                            });






                            $value1.val(test.balance);
                            // $value1.html($option.filter('[value = "' + this.value + '"]'));

                        }



                    }).trigger('change');




                    $selectp2.on('change', DataVal, function (output) {


                        if (this.value >> 0) {
                            var ind = parseFloat(this.value);


                            var test = output[ind];

                            $.each(DataVal, function (i, output) {
                                if (output.id === ind)
                                    test = output;

                            });






                            $valuep2.val(test.balance);
                            // $value1.html($option.filter('[value = "' + this.value + '"]'));

                        }



                    }).trigger('change');



                }








                if (rou1 === 'items1' || route === 'items') {



                    DataVel = Data;

                    var $select2 = $('#items1'),
                        $select2i = $('#items'),
                        $value21 = $('#breams'),
                        $value21i = $('#breamsi'),
                        $value22 = $('#bsheets'),
                        $value22i = $('#bsheetsi');




                    $select2.on('change', DataVel, function (outputt) {

                        if (this.value >> 0) {
                            var indexx = parseFloat(this.value);

                            testt = outputt[indexx];


                            $.each(DataVel, function (i, outputt) {
                                if (outputt.id === indexx)
                                    testt = outputt;

                            });

                            $value21.val(testt.balance.reams);
                            $value22.val(testt.balance.sheets);


                        }
                    }).trigger('change');






                    $select2i.on('change', DataVel, function (outputt) {

                        if (this.value >> 0) {
                            var indexx = parseFloat(this.value);

                            testt = outputt[indexx];


                            $.each(DataVel, function (i, outputt) {
                                if (outputt.id === indexx)
                                    testt = outputt;

                            });

                            $value21i.val(testt.balance.reams);
                            $value22i.val(testt.balance.sheets);


                        }
                    }).trigger('change');




                }












                debugger;
                if (route === 'banks') {
                    debugger;
                    BankData = Data;

                    debugger;
                    var $bankselect = $('#banks');



                    debugger;
                    $bankselect.on('change', BankData, function (output) {

                        debugger;
                        if (this.value >> 0) {
                            var ind = parseFloat(this.value);

                            debugger;
                            var accts = output[ind];

                            debugger;
                            var AcctData = [];


                            debugger;
                            $.each(BankData, function (i, output) {
                                if (output.id === ind)
                                    accts = output;

                            });


                            debugger;
                            if (accts != null) {
                                debugger;
                                AcctData = accts.accounts
                                debugger;
                                var DataLength = AcctData.length;
                                $("#accounts").html("<option value=''></option>");

                                debugger;
                                if (DataLength >> 0) {




                                    debugger;
                                    $("#accounts").html("<option value=''>Select Account Number</option>");
                                    debugger;
                                    $.each(AcctData, function (i, output) {
                                        debugger;
                                        $("#accounts").append(
                                            $('<option></option>').val(output.id).html(output.name));


                                    });

                                }

                            }


                        }

                    }).trigger('change');

                }







                debugger;
                //if (rou2 === 'modes2' || route === 'modes') {
                //    debugger;
                //    var ModeData = Data;

                //    debugger;
                //    var $modeselect = $('#modes2');



                //    debugger;
                //    $modeselect.on('change', ModeData, function (output) {

                //        debugger;
                //        if (this.value >> 0) {
                //            var ind = parseFloat(this.value);

                //            debugger;
                //            var mode = output[ind];

                //            debugger;
                //            var Banks = [];


                //            debugger;
                //            $.each(BankData, function (i, output) {
                //                if (output.id === ind)
                //                    mode = output;

                //            });


                //            debugger;
                //            if (mode != null) {


                                

                //                var name = mode.name.toString();
                //                $("#banks").html("<option value=''></option>");

                          
                //                if (name === "Bank Deposit" || name === "Bank Transfer" || name === "POS") {
                //                    //var DataLength = BankData.length;

                //                    debugger;
                //                    //if (DataLength >> 0) {




                //                        debugger;
                //                        $("#banks").html("<option value=''>Select Bank Name</option>");
                //                        debugger;
                //                        $.each(BankData, function (i, output) {
                //                            debugger;
                //                            $("#banks").append(
                //                                $('<option></option>').val(output.id).html(output.name));


                //                        });

                //                    //}
                //                }

                              

                //            }


                //        }

                //    }).trigger('change');

                //}





























            }


        }


    });







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
        var Data1 = response.personTypes;
        var DataLength = Data.length;

        if (DataLength > 0) {


            $("#types").html("");

            $("#types").html("<option value=''></option>");


            $("#types1").html("");

            $("#types1").html("<option value=''></option>");



            $("#types2").html("");

            $("#types2").html("<option value=''></option>");


            $.each(Data, function (i, _output) {

                var iii = ++i;

                $("#types").append(
                    $('<option></option>').val(iii).html(_output));

                $("#types1").append(
                    $('<option></option>').val(iii).html(_output));


                $("#types2").append(
                    $('<option></option>').val(iii).html(_output));

               

            });
        }

        var Data1Length = Data1.length;
        if (Data1Length > 0) {


            $("#persontypes").html("");

            $("#persontypes").html("<option value=''></option>");



            $.each(Data1, function (i, _output) {

                $("#persontypes").append(
                    $('<option></option>').val(++i).html(_output));


            });
        }

    }





    $('#newrecord').on("click", function (e) {


        e.preventDefault();

        var record =
        {
            typeId: $("#types").val(),
            itemId: $("#items").val(),
            isDamaged: $('#isdamaged').val()
        };

        record.quantity = {
            reams: $("#reams").val(),
            sheets: $("#sheets").val(),
        };



        $.ajax({
            url: "/api/records/new",
            method: "POST",
            dataType: "json",
            data: record,


            success: function (d) {
                DisplayRecord(d);





            },
            error: function () {
                alert("Error please try again");
            }

        });


        function DisplayRecord(response) {



            var Data = response


            if (Data != null) {


                $("#records").prepend(

                    $('<tr role="row"><td> <i> Added </i> </td><td>' + Data.dateAdded + '</td><td>' + Data.type + '</td><td><b>' + Data.quantity.reams + '</b> Reams <b>' + Data.quantity.sheets + '</b> Sheets</td><td>' + Data.item + '</td><td>' + Data.isDamaged + '</td><td><b>' + Data.balance.reams + '</b> Reams <b>' + Data.balance.sheets + '</b> Sheets</td><td>' + Data.destination + '</td><td></td></tr>'));

                $('#recordform').trigger("reset");

                //  $('#recordmodal').css("display", "none");


                if ($('#recordmodal').css("display", "none")) {
                    alert("Saved Successfully");
                }


            }


        }

    });



    debugger;
    
    $('#cusaddrecord').on("click", function (e) {

        debugger
        e.preventDefault();




        debugger;
        var record =
        {
            typeId: $("#types1").val(),
            itemId: $("#items1").val(),
            isDamaged: $("#isdamaged1").val(),
            amount: $("#amount").val()
        };

        record.quantity = {
            reams: $("#reams1").val(),
            sheets: $("#sheets1").val(),
        };


        debugger;

        if (record.typeId != null && record.typeId != "" && record.itemId != null && record.itemId != "" && (record.quantity.reams >> 0 || record.quantity.sheets >> 0)) {
            
            if (personrecords.records.push(record)) {

                
                DisplayRecord(record)

                totalAmount = parseFloat($("#total").val()) || 0;
                recordAmount = parseFloat(record.amount) || 0;
                balanceAmount = parseFloat($("#balance").val()) || 0;

                var bal = balanceAmount;


                totalAmount += recordAmount;

                $("#total").val(totalAmount);

                var type = parseFloat(record.typeId) || 0;



                if (type === 1) {
                    $('#balance').val(balanceAmount + totalAmount);
                }




                if (type === 2) {
                    $('#balance').val(balanceAmount - totalAmount);

                }



                $('#balance').val(balanceAmount);

            }
        }
        else {
            alert("check your entries");
        }




        
        function DisplayRecord(response) {


            debugger;
            var Data = response


            if (Data != null) {

                
                $("#cusrecord").prepend(

                    $('<tr role="row" id="new" name="new" ><td ><i>Selected</i>  </td><td>' + testt.name + '</td><td><span style="display: inline-table;     width: 40%;">' + Data.quantity.reams + '<b> Reams </b></span><span style="display: inline-table;  margin-left:5px;  width: 40%;">' + Data.quantity.sheets + '<b> Sheets </b></span></td><td>' + Data.isDamaged + '</td><td><span style="display: inline-table;     width: 40%;"></span> <span style="display: inline-table; margin-left:5px;   width: 40%;"></span></td><td>' + Data.amount + '</td>     </tr>'));


                $("#items1").val("");
                $("#amount").val("");



            }







        }

    });








    debugger;


    debugger;
    $('#newcusrecord').on("click", function (e) {


        e.preventDefault();


        debugger;
        personrecords.recordDetails = {
            personId: $("#persons").val(),
            receiptId: $("#receipts").val(),
            receiptNumber: $("#receiptnum").val()

        };


        



           debugger;
            $.ajax({
                url: "/api/records/personrecords",
                method: "POST",
                dataType: "json",
                data: personrecords,


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
                var Data = response


                debugger;
                if (Data != null) {


                    var DataLength = Data.length;

                    if (DataLength >> 0) {

                        debugger;
                        $.each(Data, function (i, output) {

                            $("#records").prepend(

                                $('<tr role="row"><td> <i> Added </i> </td><td>' + output.dateAdded + '</td><td>' + output.type + '</td><td><b>' + output.quantity.reams + '</b> Reams <b>' + output.quantity.sheets + '</b> Sheets</td><td>' + output.item + '</td><td>' + output.isDamaged + '</td><td><b>' + output.balance.reams + '</b> Reams <b>' + output.balance.sheets + '</b> Sheets</td><td>' + output.destination + '</td><td></td></tr>'));

                        });


                    }


                    $('#cusbody').children("tr").remove();

                    $('#cusrecordform').trigger("reset");


                    // $('#cusrecordform').css("display", "none");



                    if ($('#cusrecordmodal').hide()) {
                        alert("Saved Successfully");
                    }



                }



            }

    });





   



});


