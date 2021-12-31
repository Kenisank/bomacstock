

//$(document).ready(function () {

//    var rouu = "";





//    var count = 0,
//        totalAmount = 0,
//        recordAmount = 0,
//        balanceAmount = 0;

//    var DataVel = new Object(),
//        testt = new Object(),
//        payment = {}




//    record = {
//        records: []
//    };

//    var form = {
//        record,
//        payment
//    }

//    personformresource = {

//    };

//    //if ($('#balance').val() < 0) {
//    //    $('#balance').val().fontcolor(red);
//    //}





//    //$("#statemment").on("click", function () {

//    //    



//    //    $('#formhtml').load('/Person/Statements #statementformhtml');


//    //    
//    //    var btn = $(this);
//    //    var num = btn.attr("data-person-id");

//    //    $.ajax({
//    //        url: "/api/records/statements/" + num,
//    //        method: "Get",
//    //        dataType: "json",
//    //        data: "{}",

//    //        success: function (data) {
//    //            

//    //            PolulateStatementModel(data);


//    //        },
//    //        error: function () {
//    //            alert("Please reload browser")
//    //        }

//    //    });



//    //});



//    //function PolulateStatementModel(person) {

//    //    


//    //    $("#statementperson").val(person.name);
//    //    $("#statementuniqe").val(person.uniqueNo);
//    //    $("#statementphone").val(person.phone);
//    //    $("#statementaddress").val(person.address);
//    //    $("#statementbal").val(person.balance);
//    //    

//    //    if (person.balance < 0) {
//    //        $('#statementbal').css("color", "red");
//    //    }




//    //    

//    //    PopulateStatementTable(person.id)

//    //    $("#ordertotal").val(person.total);

//    //}












    

//    var shares = ['items', 'persons', 'receipts', 'modes', 'banks', 'accounts', 'categories', 'states']


//    $.each(shares, function (i, share) {

//        var route = share.toString();

//        $.ajax({
//            url: "/api/shared/" + route,
//            method: "Get",
//            dataType: "json",
//            data: "{}",


//            success: function (data) {

//                DisplayDropDown(data);
//            },
//            error: function () {
//                alert("Please reload browser")
//            }

//        });

//        function DisplayDropDown(response) {



//            var Data = response;

//            var DataLength = Data.length;

//            if (DataLength >> 0) {


//                $("#" + route).html("");

//                $("#" + route).html("<option value=''></option>");

//                var rou = route + "1";

//                rouu = route + "2";

//                var rouuu = route + "3";


//                $("#" + rou).html("");

//                $("#" + rou).html("<option value=''></option>");




//                $("#" + rouu).html("");

//                $("#" + rouu).html("<option value=''></option>");



//                $("#" + rouuu).html("");

//                $("#" + rouuu).html("<option value=''></option>");






//                $.each(Data, function (i, output) {

//                    $("#" + route).append(
//                        $('<option></option>').val(output.id).html(output.name));

//                    $("#" + rou).append(
//                        $('<option></option>').val(output.id).html(output.name));


//                    $("#" + rouu).append(
//                        $('<option></option>').val(output.id).html(output.name));


//                    $("#" + rouuu).append(
//                        $('<option></option>').val(output.id).html(output.name));




//                });


//                //


//                if (route === 'persons') {

//                    //

//                    var DataVal = Data;


//                    var $select1 = $('#persons'),
//                        $balvalue1 = $('#balance');


//                    //
//                    $select1.on('change', DataVal, function (output) {

//                        //
//                        if (this.value >> 0) {
//                            var ind = parseFloat(this.value);


//                            var test = output[ind];

//                            $.each(DataVal, function (i, output) {
//                                if (output.id === ind)
//                                    test = output;

//                            });






//                            $balvalue1.val(test.balance);
//                            // $value1.html($option.filter('[value = "' + this.value + '"]'));

//                        }



//                    }).trigger('change');




//                    //
//                    if (rouu === 'persons2') {
//                        //



//                        var $select1 = $('#persons2'),
//                            $value1 = $('#bal2');



//                        $select1.on('change', DataVal, function (output) {


//                            if (this.value >> 0) {
//                                var ind = parseFloat(this.value);


//                                var test = output[ind];

//                                $.each(DataVal, function (i, output) {
//                                    if (output.id === ind)
//                                        test = output;

//                                });






//                                $value1.val(test.balance);
//                                // $value1.html($option.filter('[value = "' + this.value + '"]'));

//                            }



//                        }).trigger('change');

//                    }


//                }








//                if (rou === 'items1' || route === 'items') {


//                    //
//                    DataVel = Data;

//                    var $select2 = $('#items1'),
//                        $select2i = $('#items'),
//                        $value21 = $('#breams'),
//                        $value21i = $('#breamsi'),
//                        $value22 = $('#bsheets'),
//                        $value22i = $('#bsheetsi');




//                    $select2.on('change', DataVel, function (outputt) {

//                        if (this.value >> 0) {
//                            var indexx = parseFloat(this.value);

//                            testt = outputt[indexx];


//                            $.each(DataVel, function (i, outputt) {
//                                if (outputt.id === indexx)
//                                    testt = outputt;

//                            });

//                            $value21.val(testt.balance.reams);
//                            $value22.val(testt.balance.sheets);


//                        }
//                    }).trigger('change');













//                    $select2i.on('change', DataVel, function (outputt) {

//                        if (this.value >> 0) {
//                            var indexx = parseFloat(this.value);

//                            testt = outputt[indexx];


//                            $.each(DataVel, function (i, outputt) {
//                                if (outputt.id === indexx)
//                                    testt = outputt;

//                            });

//                            $value21i.val(testt.balance.reams);
//                            $value22i.val(testt.balance.sheets);


//                        }
//                    }).trigger('change');




//                }






//                //
//                if (route === 'banks') {
//                    //
//                    var BankData = Data;


//                    var $bankselect = $('#banks');



//                    //
//                    $bankselect.on('change', BankData, function (output) {

//                        //
//                        if (this.value >> 0) {
//                            var ind = parseFloat(this.value);

//                            //
//                            var accts = output[ind];
//                            var AcctData = [];


//                            //
//                            $.each(BankData, function (i, output) {
//                                if (output.id === ind)
//                                    accts = output;

//                            });


//                            //
//                            if (accts != null) {
//                                //
//                                AcctData = accts.accounts

//                                var DataLength = AcctData.length;
//                                $("#accounts").html("<option value=''></option>");
//                                if (DataLength >> 0) {


//                                    $("#accounts").html("<option value=''>Select Account Name</option>");
//                                    //
//                                    $.each(AcctData, function (i, output) {

//                                        $("#accounts").append(
//                                            $('<option></option>').val(output.id).html(output.name));


//                                    });

//                                }

//                            }


//                        }

//                    }).trigger('change');

//                }







//            }


//        }


//    });



    
//    $.ajax({
//        url: "/api/shared/enums",
//        method: "Get",
//        dataType: "json",
//        data: "{}",

//        success: function (data) {
//            DisplayEnums(data);
//        },
//        error: function () {
//            alert("Please reload browser")
//        }

//    });

//    function DisplayEnums(response) {


        
//        var Data = response.stockTypes;
//        var Data1 = response.personTypes;


//        var DataLength = Data.length;

//        if (DataLength > 0) {


//            $("#types").html("");

//            $("#types").html("<option value=''></option>");


//            $("#types1").html("");

//            $("#types1").html("<option value=''></option>");


//            $("#types2").html("");

//            $("#types2").html("<option value=''></option>");






//            $.each(Data, function (i, _output) {

//                $("#types").append(
//                    $('<option></option>').val(++i).html(_output));

//                $("#types1").append(
//                    $('<option></option>').val(i).html(_output));

//                $("#types2").append(
//                    $('<option></option>').val(i).html(_output));

//            });
//        }



//        var Data1Length = Data1.length;

//        if (Data1Length > 0) {


//            $("#persontypes").html("");

//            $("#persontypes").html("<option value=''></option>");

            

//            $.each(Data1, function (i, _output) {

//                $("#persontypes").append(
//                    $('<option></option>').val(++i).html(_output));


//            });
//        }


//    }













//    //

//    $('#cusaddrecord').on("click", function (e) {


//        e.preventDefault();



//        //

//        var record =
//        {
//            typeId: $("#types1").val(),
//            itemId: $("#items1").val(),
//            isDamaged: $("#isdamaged1").val(),
//            amount: $("#amount").val()
//        };

//        record.quantity = {
//            reams: $("#reams1").val(),
//            sheets: $("#sheets1").val(),
//        };




//        if (record.typeId != null && record.typeId != "" && record.itemId != null && record.itemId != "" && (record.quantity.reams >> 0 || record.quantity.sheets >> 0)) {

//            if (form.record.records.push(record)) {
//                PendRecord(record)



//                totalAmount = parseFloat($("#total").val()) || 0;
//                recordAmount = parseFloat(record.amount) || 0;
//                balanceAmount = parseFloat($("#balance").val()) || 0;
//                var bal = balanceAmount;


//                totalAmount += recordAmount;

//                $("#total").val(totalAmount);

//                var type = parseFloat(record.typeId) || 0;



//                if (type === 1) {
//                    $('#balance').val(balanceAmount + totalAmount);
//                }





//                if (type === 2) {
//                    $('#balance').val(balanceAmount - totalAmount);

//                }
//                //balanceAmount -= totalAmount;


//                //if ($('#balance').val() < 0) {
//                //    $('#balance').val().fontcolor("red");
//                //}


//                $('#balance').val(balanceAmount);

//                //  if ($('#balance').val() < 0) {
//                //      //$('#balance').val().fontcolor("red");
//                //      // $('#cusrecordform').css("display", "none");

//                //      $('#balance').css("font", "red");

//                //}
//            }
//        }
//        else {
//            alert("check your entries");
//        }





//        function PendRecord(response) {



//            var Data = response


//            if (Data != null) {


//                $("#cusrecord").prepend(

//                    $('<tr role="row" id="new" name="new" ><td ><i>Selected</i>  </td><td>' + testt.name + '</td><td><span style="display: inline-table;     width: 40%;">' + Data.quantity.reams + '<b> Reams </b></span><span style="display: inline-table;  margin-left:5px;  width: 40%;">' + Data.quantity.sheets + '<b> Sheets </b></span></td><td>' + Data.isDamaged + '</td><td><span style="display: inline-table;     width: 40%;"></span> <span style="display: inline-table; margin-left:5px;   width: 40%;"></span></td><td>' + Data.amount + '</td>     </tr>'));


//                $("#items1").val("");
//                $("#amount").val("");



//            }







//        }

//    });














//    $('#newrecord').on("click", function (e) {


//        e.preventDefault();


//        //


//        var record =
//        {
//            typeId: $("#types").val(),
//            itemId: $("#items").val(),
//            isDamaged: $('#isdamaged').val()
//        };

//        record.quantity = {
//            reams: $("#reams").val(),
//            sheets: $("#sheets").val(),
//        };



//        $.ajax({
//            url: "/api/records/new",
//            method: "POST",
//            dataType: "json",
//            data: record,


//            success: function (d) {
//                DisplayRecord(d);





//            },
//            error: function () {
//                alert("Error please try again");
//            }

//        });


//        function DisplayRecord(response) {



//            var Data = response


//            if (Data != null) {


//                $("#records").prepend(

//                    $('<tr role="row"><td> <i> Added </i> </td><td>' + Data.dateAdded + '</td><td>' + Data.type + '</td><td><b>' + Data.quantity.reams + '</b> Reams <b>' + Data.quantity.sheets + '</b> Sheets</td><td>' + Data.item + '</td><td>' + Data.isDamaged + '</td><td><b>' + Data.balance.reams + '</b> Reams <b>' + Data.balance.sheets + '</b> Sheets</td><td>' + Data.destination + '</td><td></td></tr>'));

//                $('#recordform').trigger("reset");

//                //  $('#recordmodal').css("display", "none");


//                if ($('#recordmodal').css("display", "none")) {
//                    alert("Saved Successfully");
//                }




//            }







//        }

//    });




    
//    $('#newcusrecord').on("click", function (e) {


//        e.preventDefault();


//        //
//        form.record.recordDetails = {
//            personId: $("#persons").val(),
//            receiptId: $("#receipts").val(),
//            receiptNumber: $("#receiptnum").val()

//        };





//        form.payment = {
//            personId: $("#persons").val(),
//            modeId: $("#modes").val(),
//            amount: $("#payamount").val(),
//            ref: $("#payref").val(),
//            accountId: $("#accounts").val(),
//            typeId: $("#types2").val()
//        }


//        if (form.payment.modeId > 0 || form.payment.amount > 0 || form.payment.ref != "" || form.payment.accountId > 0 || form.payment.typeId > 0) {
//            if (form.payment.modeId > 0 && form.payment.amount > 0 && form.payment.amount != "" && form.payment.ref != null && form.payment.ref != "" && form.payment.accountId > 0 && form.payment.typeId > 0) {


//                AddPersonRecord(form);

//            }
//            else {
//                alert("Check Payment Entries");
//            }
//        }
//        else {
//            AddPersonRecord(form);
//        }


//        //$.each(personrecords.records, function (i, _record) {

//        //    _record.typeId = $("#types1").val();

//        //});



//        function AddPersonRecord(form) {
//            $.ajax({
//                url: "/api/records/personrecords",
//                method: "POST",
//                dataType: "json",
//                data: form,


//                success: function (d) {



//                    DisplayRecord(d);





//                },
//                error: function () {
//                    alert("Error please try again");
//                }

//            });


//            function DisplayRecord(response) {



//                var Data = response



//                if (Data != null) {


//                    var DataLength = Data.length;

//                    if (DataLength >> 0) {


//                        $.each(Data, function (i, output) {

//                            $("#records").prepend(

//                                $('<tr role="row"><td> <i> Added </i> </td><td>' + output.dateAdded + '</td><td>' + output.type + '</td><td><b>' + output.quantity.reams + '</b> Reams <b>' + output.quantity.sheets + '</b> Sheets</td><td>' + output.item + '</td><td>' + output.isDamaged + '</td><td><b>' + output.balance.reams + '</b> Reams <b>' + output.balance.sheets + '</b> Sheets</td><td>' + output.destination + '</td><td></td></tr>'));

//                        });


//                    }


//                    $('#cusbody').children("tr").remove();

//                    $('#cusrecordform').trigger("reset");


//                    // $('#cusrecordform').css("display", "none");



//                    if ($('#cusrecordmodal').hide()) {
//                        alert("Saved Successfully");
//                    }

//                }

//            }
//        }



//    });




    
//    $('#newcategory').on("click", function (e) {
        
//        e.preventDefault();

//        var category = {
//            name: $("#catname").val()
//        };

//        if (category.name != null && category.name != "") {
//            AddCategory(category);
//        }
//        else {
//            alert("check your entry");
//        }
        
//        function AddCategory(entry) {
            
//            $.ajax({
//                url: "/api/stock/categories/add",
//                method: "POST",
//                dataType: "json",
//                data: entry,



//                success: function (d) {
//                    DisplayCategory(d)

//                },
//                error: function () {
//                    alert("Error please try again");
//                }

//            });


//            function DisplayCategory(response) {

//                var Data = response


//                if (Data != null) {


//                    $("#stockcategories").prepend(

//                        $('<tr role="row"><td> <i> Added </i> </td><td>' + Data.name + '</td><td>' + Data.items + '</td></tr>'));

//                    $('#categoryform').trigger("reset");

//                    //  $('#recordmodal').css("display", "none");


//                    if ($('#categorymodal').css("display", "none")) {
//                        alert("Saved Successfully");
//                    }
//                }
//            }

//        }
//    });

    
//    $('#newitem').on("click", function (e) {
        
//        e.preventDefault();

//        var item = {
//            name: $("#itemname").val(),
//            noOfSheets: $("#itemsheets").val(),
//            manufactuturer: $("#mani").val(),
//            categoryId: $("#categories").val()

//        };


//        item.noOfStock = {
//            reams: $("#itemamtreams").val(),
//            sheets: $("#itemamtsheets").val()
//        }

//        if (item.name != null && item.name != "" && item.manufactuturer != null && item.manufactuturer != "") {
//            AddItem(item);
//        }
//        else {
//            alert("check your entry");
//        }
        
//        function AddItem(entry) {
            
//            $.ajax({
//                url: "/api/stock/items/add",
//                method: "POST",
//                dataType: "json",
//                data: entry,



//                success: function (d) {

                    
//                    DisplayItem(d);
//                },
//                error: function () {
//                    alert("Error please try again");
//                }

//            });


            
//            function DisplayItem(respon) {

//                var Data = respon


//                if (Data != null) {

                    
//                    $("#stockitems").prepend(

//                        $('<tr role="row"><td> <i> Added </i> </td><td>' + Data.name + '</td><td><b>' + Data.noOfStock.reams + '</b> Reams <b>' + Data.noOfStock.sheets + '</b> Sheets</td><td>' + Data.damaged + '</td></tr>'));

                    
//                    $('#itemform').trigger("reset");

//                    //  $('#recordmodal').css("display", "none");

                    
//                    if ($('#itemmodal').css("display", "none")) {

                        
//                        alert("Saved Successfully");
//                    }
//                }
//            }

//        }
//    });



    
//    $('#newperson').on("click", function (e) {


//        e.preventDefault();






        
//        personformresource = {
//            name: $("#personname").val(),
//            address: $("#personaddress").val(),
//            balance: $("#personbal").val(),
//            stateId: $("#states").val(),
//            typeId: $("#persontypes").val(),
//            pPhoneNo: $("#personphone").val(),
//            email: $("#personemail").val(),
//            web: $("#personweb").val()

//        }




//        if (personformresource.name != null && personformresource.name != ""
//            && personformresource.address != null && personformresource.address != ""
//            && personformresource.pPhoneNo != null && personformresource.pPhoneNo != "") {
//            AddPerson(personformresource);
//        }
//        else {
//            alert("check your entry");
//        }

        
//        function AddPerson(personformresource) {
            
//            $.ajax({
//                url: "/api/persons/add",
//                method: "POST",
//                dataType: "json",
//                data: personformresource,


//                success: function (d) {


                    
//                    DisplayPerson(d);





//                },
//                error: function () {
//                    alert("Error please try again");
//                }

//            });


//            function DisplayPerson(response) {


                
//                var output = response



//                if (output != null) {

//                    $("#personstable").prepend(

//                        $('<tr role="row"><td> <i> Added </i> </td><td>' + output.name + '</td><td>' + output.uniqueNo + '</td><td>' + output.phone + '</td><td>New</td><td>' + output.balance + '</td><tdbutton data-order-num="' + output.lastRecord + '" class="btn-link js-single" > New </button ></td ></tr > '));





//                    $('#personform').trigger("reset");


//                    // $('#cusrecordform').css("display", "none");

//                    if ($('#personmodal').css("display", "none")) {
//                        alert("Saved Successfully");
//                    }

//                    //if ($('#personmodal').hide()) {
//                    //    alert("Saved Successfully");
//                    //}










//                }



//            }
//        }



//    });


//});


