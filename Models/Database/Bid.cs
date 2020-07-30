using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ProjectIepAuction.Models.Database{
    public class Bid {
 
        
        public int price {get; set;} 
 
        public DateTime bidDate {get; set;}

        public string userId {get; set;}
        public User user {get; set;}

        public int auctionId {get; set;}
        public Auction auction {get; set;}
        
        
 
    }

       public class BidConfiguration : IEntityTypeConfiguration<Bid>
        {
        public void Configure(EntityTypeBuilder<Bid> builder)
        {
            builder.HasKey(
                entity => new {entity.userId, entity.auctionId} 
            );

            

        }
    }
 
}
