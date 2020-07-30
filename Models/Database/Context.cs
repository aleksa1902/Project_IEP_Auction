using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
 
namespace ProjectIepAuction.Models.Database{
 
    public class ProjectIepAuctionContext : IdentityDbContext<User>{
 
        public DbSet<BagToken> BagTokens {get; set;} 
        public DbSet<TokenTransaction> TokenTransactions {get; set;} 
        public DbSet<Auction> Auctions {get; set;} 
        public DbSet<Bid> Bids {get; set;} 

        public ProjectIepAuctionContext(DbContextOptions options):base(options){}
 
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new IdentityRoleConfiguration());
            builder.ApplyConfiguration(new BagTokenConfiguration());
            builder.ApplyConfiguration(new TokenTransactionConfiguration());
            
            builder.ApplyConfiguration(new AuctionConfiguration());
        }


 
    }
 
}