$(document).ready(function () {

  
    
    
    var personcount = 0;

    $("#personstable").DataTable({

        ajax: {
            url: "/api/persons/all",
            method: "Get",
            dataType: "json",
            dataSrc: ""
        },

        columns: [

            {

                data: "",
                render(data) {
                    return '<b>' + ++personcount + '</b>'
                }
            },
            {
                data: "name",
                render: function (data, type, personsResouces) {
                    return '<button data-person-id="' + personsResouces.id + '" class="btn-link js-person" >' + personsResouces.name + '</button>'
                }


            },
            {
                data: "uniqueNo"

            },

             {
                 data: "phone",


             },
              {
                  data: "state",


              },
              {
                  data: "balance",
                  render(data) {
                      return '<b>' + data + '</b>'

                  }

              },

              {
                  data: "lastRecord",
                  render: function (data, type, personsResouces) {
                       return '<button data-order-num="' + personsResouces.recordId + '" class="btn-link js-single" >' + data + '</button'
                   }


              }

        ]



    });





    $("#personstable").on("click", ".js-single", function () {

        //$('#singlerecordmodal').css("display", "block");

        $('#singlerecordmodal').show();

        
        var btn = $(this);
        var num = btn.attr("data-order-num");
        
        $.ajax({
            //url: "/api/records/singledetails/" + num,
            //method: "Get",
            //dataType: "json",
            //data: "{}",


            url: "/api/records/singledetails/" + num,
            method: "Get",
            dataType: "json",
            data: "{}",

            
            success: function (data) {
                
                PolulateSingleModel(data);
            },
            error: function () {
                alert("Please reload browser")
            }

        });



    });



    $("#singlerecordmodal").on("click", ".js-close", function () {
        

        $('#singleform').trigger("reset");
        $('#singlebody').children("tr").remove();
    });

    
    function PolulateSingleModel(personrecord) {

        
        $("#singleperson").val(personrecord.person);
        $("#singletype").val(personrecord.type);
        $("#singleref").val(personrecord.receipt);
        $("#singleord").val(personrecord.orderNum);
        $("#singlebal").val(personrecord.balance);
        

        if (personrecord.balance < 0) {
            $('#singlebal').css("color", "red");
        }




        

        PopulateSingleTable(personrecord.records)

        $("#singletotal").val(personrecord.total);







        //$("#singlerecordtable").DataTable({

        //    ajax: {
        //        url: "/api/records/singlerecords/" + record,
        //        method: "Get",
        //        dataType: "json",
        //        dataSrc: ""


        //    },




        //    columns: [
        //        {

        //            data: "",
        //            render(data) {
        //                return '<b>' + ++personrecordcount + '</b>'
        //            }
        //        },
        //        {
        //            data: "item",


        //        },


        //          {
        //              data: "quantity",
        //              render(data) {
        //                  return '<b>' + data.reams + '</b>' + " Reams " + '<b>' + data.sheets + '</b>' + " Sheets"

        //              }

        //          },

        //          {
        //              data: "isDamaged",


        //          },
        //          {
        //              data: "amount",


        //          }

        //    ]
        //});
    }




    function PopulateSingleTable(records) {



        var Data = records;

        var DataLength = Data.length;

        if (DataLength >> 0) {


            var personrecordcount = 0;


            $.each(Data, function (i, output) {

                $("#singlerecordtable").append(

                  $('<tr role="row"><td> <i>' + ++personrecordcount + '</i> </td><td>' + output.item + '</td><td>' + '<b>' + output.quantity.reams + '</b>' + " Reams " + '<b>' + output.quantity.sheets + '</b>' + " Sheets" + '</td><td>' + output.isDamaged + '</td><td>' + output.amount + '</td></tr>'));




            });






        }


    }







    

    $("#personstable").on("click", ".js-person", function () {

      
      

        


        
        var btn1 = $(this);
        var num1 = btn1.attr("data-person-id");
        $('#formhtml').load('/Person/Statements #statementform');

        $.ajax({
            url: "/api/records/statements/" + num1,
            method: "Get",
            dataType: "json",
            data: "{}",

            success: function (data) {
                

                PolulateOrderModel(data);


            },
            error: function () {
                alert("Please reload browser")
            }

        });



    });



    function PolulateOrderModel(person) {

        

      



        $("#statementperson").val(person.name);
        $("#statementuniqe").val(person.uniqueNo);
        $("#statementphone").val(person.phone);
        $("#statementaddress").val(person.address);
        $("#statementbal").val(person.balance);
        

        if (person.balance < 0) {
            $('#statementbal').css("color", "red");
        }




        

        PopulateOrderTable(person.id)

        $("#statementtotal").val(person.total);

    }


    
    function PopulateOrderTable(id) {
        
        var ordercount = 0;

        

        $("#statementrecordtable").DataTable({

            

            ajax: {
                url: "/api/records/statements/records/" + id,
                method: "Get",
                dataType: "json",
                dataSrc: ""
            },

            columns: [

                {

                    data: "",
                    render(data) {
                        return '<b>' + ++ordercount + '</b>'
                    }
                },
                 {
                     data: "date"

                 },
               
                {
                    data: "type"

                },
                {
                    data:"description"

                },
                
                {
                    data: "ref"

                },
                
                  {
                      data: "debit",
                     


                  },
                  {
                      data: "credit",
                      


                  },

                  {
                      data: "balance",


                  }

            ]



        });





    }




});