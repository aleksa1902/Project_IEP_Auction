using System.Collections.Generic;
using ProjectIepAuction.Models.Database;
using X.PagedList;

namespace ProjectIepAuction.Models.View
{
    public class TokenOrders{
        public IPagedList<TokenTransaction> transactions {get; set;}
        public int tokens{get; set;}

    }
}