using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheDadsDepot.Models
{
    public class EFDepotRepository : IDepotRepository
    {
        private DepotDbContext context;

        public EFDepotRepository(DepotDbContext ctx)
        {
            context = ctx;
        }

        public IQueryable<Product> Products => context.Products;
    }
    
    
}
