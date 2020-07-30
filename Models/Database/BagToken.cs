using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ProjectIepAuction.Models.Database
{
    public class BagToken
    {
        [Key]
        public int Id {get; set;}

        [Required]
        public string bagName {get; set;}

        [Required]
        public int amount {get; set;}

        [Required]
        public double price {get; set;}

        public ICollection<TokenTransaction>  TokenTransactionList{get; set;}


    }

    public class BagTokenConfiguration : IEntityTypeConfiguration<BagToken>
    {
        public void Configure(EntityTypeBuilder<BagToken> builder)
        {
            builder.Property( item => item.Id).ValueGeneratedOnAdd();

            builder.HasData(
                new BagToken[]{
                    new BagToken()
                    {
                        Id = 1,
                        bagName = "Silver",
                        amount = 5,
                        price = 4.99
                      
                    },
                    new BagToken()
                    {
                        Id = 2,
                        bagName = "Gold",
                        amount = 10,
                        price = 9.99
                      
                    },
                    new BagToken()
                    {
                        Id = 3,
                        bagName = "Platinum",
                        amount = 20,
                        price = 17.99 
                      
                    } 
                } 

            );
        }
    }
}