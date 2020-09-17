"use strict";

var connection = new signalR.HubConnectionBuilder().withUrl("/bidHub").build();

connection.on("ReceiveBid", function (price, winner, auctionId, date) {
    document.getElementById("price"+auctionId).innerHTML= price;
    document.getElementById("winner"+auctionId).innerHTML= winner;
    if(date != "NULL"){
        //alert("TU SAM " + date);
        $(".closeTime"+auctionId).val(date);
    }
});

function handleError(error){
    alert(error);
}

connection.start().then(
    function(){}
    ).catch(handleError);

function Bid(auctionId){

    var price = document.getElementById("price"+auctionId).innerHTML;
    price = parseInt(price);
    price = price + 1;

    var verificationToken = $("input[name='__RequestVerificationToken']").val ( )

    $.ajax ({  
        type: "POST", 
        url: "/User/Bid", 
        data: { 
            "auctionId": auctionId,
            "__RequestVerificationToken" : verificationToken 
        },
        dataType: "json",
        success: function ( response ) {
            if(response.flag == true){
                if(response.closeDate != null){
                    connection.invoke("BidMessage", price.toString(), response.newWinner.toString(), auctionId.toString(), response.closeDate.toString()).catch(function (err) {
                        return console.error(err.toString());
                    });
                }else{
                    connection.invoke("BidMessage", price.toString(), response.newWinner.toString(), auctionId.toString(), "NULL").catch(function (err) {
                        return console.error(err.toString());
                    });
                }
                
            }else{
                alert(response.alert);
            }     
        },
        error: function ( response ) {
            alert ( "Sorry, you dont have tokens." );
        }
    });
}

function close(auctionId){
    var verificationToken = $("input[name='__RequestVerificationToken']").val( );
    $.ajax ({  
        type: "POST", 
        url: "/User/CloseBid",
        data: {
            "auctionId" : auctionId,
            "__RequestVerificationToken" : verificationToken
        },
        dataType: "json",
        success: function ( response ) {
            connection.invoke("CloseAuction", auctionId.toString()).catch(function (err) {
                return console.error(err.toString());
            });
           
        },
        error: function ( response ) {

        }
    });   

}

connection.on("closeAuction",function (auctionId){
     document.getElementById("changeColor"+auctionId).innerHTML = "<div class='list-group-item bg-danger text-white' style='text-align: center;'>CLOSED</div>";
     document.getElementById("divBid"+auctionId).innerHTML = "<div class='list-group-item bg-danger text-white' style='text-align: center;'>CLOSED</div>";
    }
);

function countDown(){
    var i;
    for(i=1; i<=12; i++){
        var string = $("#closeTime"+i).val();
        if(string==null)
            break;
        
           
        var array = string.split(",");
    
        var now = new Date();

        var eventDate = new Date(array[0], array[1] - 1, array[2], array[3], array[4], array[5], 0);

        var currentTime = now.getTime();
        var eventTime = eventDate.getTime();
 
        var remTime = eventTime - currentTime; 
        
        if(parseInt(remTime) < 0){
            var auctionId = $("#auctionId"+i).val();
            close(auctionId);
            continue;
        }
 
        var s = Math.floor(remTime / 1000);
        var m = Math.floor(s / 60);
        var h = Math.floor(m / 60);
        var d = Math.floor(h / 24);
 
        h %= 24;
        m %= 60;
        s %= 60;
        d %= 30;
 
        h = h - 1 < 0 ? 0 : h; 
 
        h = (h<10) ? "0" + h : h;
        m = (m<10) ? "0" + m : m;
        s = (s<10) ? "0" + s : s;
        d = (d < 10) ? "0" + d : d;
 
        $("#time"+i).text( d + ":" + h + ":" + m + ":" + s );
 
    }
 
    
}
setInterval(countDown,1000);