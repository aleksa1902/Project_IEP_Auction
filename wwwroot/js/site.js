﻿// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


function buyTokens ( ) {
    var verificationToken = $("input[name='__RequestVerificationToken']").val ( ) //Znaci ovde ga dohvatimo, on se nalazi na svakoj starnici

    $.ajax ({  //on se ovako pise
        type: "POST", //koji je tip zahteva POST
        url: "/Payment/Payment", //Sta se pozviva, /ControllerName/ControllerMethodName
        data: { //Podaci koji se salju metodi kontrolera i to ka JSON objekat
            "bagName": $("input[name='tokenbag']:checked").val(), //to je onaj parametar sto on trazi bagName
            "__RequestVerificationToken" : verificationToken // i za kraj taj token za verifikaciju
        },
        success: function ( response ) {
            location.reload(); //Sta se desava kada je metoda uspesna, kada vrati JSON true objekat, ja sam mu reko da se stranice refreshuje, kako bi se osvezilo stanje, mozemo to da uradimo i na mnogo bolji nacin, provbacemo, brzo se radi
        },
        error: function ( response ) {
            alert ( response ) // i sta se desava kada funkcija nije uspela, ispisace se alert :D
        }
    })
}


$( document ).ready(function() {
    paypal.Buttons ( {
        createOrder: function ( data, actions ) {
            return actions.order.create ( {
                purchase_units: [{
                    amount: {
                        value: $("input[name='tokenbag']:checked").val()
                    }
                }]
            } )
        },
        onApprove: function ( data, actions ) {
            return actions.order.capture ( ).then (
                function ( details ) {
                    buyTokens(); //i ovde kada je PayPal uspeo, prikaze se alert da je sve uspesno, obavi se upisu bazu i refreshuje se stranica :D moz

                }
            )
        }
    } ).render ( "#paypal" )
    
});


function banUser(username)
{
    var verificationToken = $("input[name='__RequestVerificationToken']").val ( )
    
    $.ajax ({  
        type: "POST", 
        url: "/Administrator/Ban", 
        data: { 
            "username": username,
            "__RequestVerificationToken" : verificationToken 
        },
        dataType: "text",
        success: function ( response ) {
            $("#"+username).html(response) 
        },
        error: function ( response ) {
            alert ( response ) 
        }
    })
}

function unbanUser(username)
{
    var verificationToken = $("input[name='__RequestVerificationToken']").val ( )
    
    $.ajax ({  
        type: "POST", 
        url: "/Administrator/Unban", 
        data: { 
            "username": username,
            "__RequestVerificationToken" : verificationToken 
        },
        dataType: "text",
        success: function ( response ) {
            $("#"+username).html(response) 
        },
        error: function ( response ) {
            alert ( response ) 
        }
    })
}

function acceptAuction(id)
{
    var verificationToken = $("input[name='__RequestVerificationToken']").val ( )
    
    $.ajax ({  
        type: "POST", 
        url: "/Administrator/AcceptAuction", 
        data: { 
            "id": id,
            "__RequestVerificationToken" : verificationToken 
        },
        dataType: "text",
        success: function ( response ) {
            location.reload();
        },
        error: function ( response ) {
            location.reload(); 
        }
    })
}

function declineAuction(id)
{
    var verificationToken = $("input[name='__RequestVerificationToken']").val ( )
    
    $.ajax ({  
        type: "POST", 
        url: "/Administrator/DeclineAuction", 
        data: { 
            "id": id,
            "__RequestVerificationToken" : verificationToken 
        },
        dataType: "text",
        success: function ( response ) {
            location.reload();
        },
        error: function ( response ) {
            location.reload(); 
        }
    })
}

function nextPage(nextPage){
    var search = $("#search").val();
    var minPrice = $("#minPrice").val();
    var maxPrice = $("#maxPrice").val();
    var state = $("#state").children("option:selected").val();

    if(search == "" && minPrice == "" && maxPrice == "" && state == "OPEN"){
        $.ajax ({  
            type: "POST", 
            url: "/Home/NextPage", 
            data: { 
                "page":nextPage,
            },
            dataType: "text",
            success: function ( response ) {
                $("#auction").html(response);
            },
            error: function ( response ) {
                alert ( response ) 
            }
        });
    }else{
        $.ajax ({  
            type: "POST", 
            url: "/Home/FilteredPage", 
            data: { 
                "page":nextPage,
                "search":search,
                "minimumPrice":minPrice,
                "maximumPrice":maxPrice,
                "state":state
            },
            dataType: "text",
            success: function ( response ) {
                $("#auction").html(response);
            },
            error: function ( response ) {
                alert ( response ) 
            }
        });
    }

    
}

function clickHandler(delay){
    if(search != "" && minPrice != "" && maxPrice != "" && state != "OPEN"){
    setTimeout( function() { nextPage('1'); }, delay );
    }
}

function nadjiUsera(id, i){
    var verificationToken = $("input[name='__RequestVerificationToken']").val ( )

    return $.ajax ({  
        type: "POST", 
        url: "/User/FindUser", 
        data: { 
            "auctionId": id,
            "i": i,
            "__RequestVerificationToken" : verificationToken 
        },
        dataType: "text",
        success: function ( response ) {
            alert(response);
            document.getElementById("winner"+i).innerHTML = response;       
        },
        error: function ( response ) {
            alert ( "Sorry, you dont have tokens." ) 
        }
    });
}