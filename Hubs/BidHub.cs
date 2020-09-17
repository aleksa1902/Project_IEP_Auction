using Microsoft.AspNetCore.SignalR;
using System;
using System.Threading.Tasks;

namespace ProjectIepAuction.Hubs
{
    public class BidHub : Hub
    {
        public async Task BidMessage(string price, string winner, string auctionId, string date){
            await Console.Out.WriteLineAsync("USAO SAM U HUB");
            await Clients.All.SendAsync("ReceiveBid", price, winner, auctionId, date);
        }

        public async Task CloseAuction(string auctionId){
            await Console.Out.WriteLineAsync("USAO SAM U HUB");
            await base.Clients.All.SendAsync("closeAuction", auctionId);

        }
    }
}