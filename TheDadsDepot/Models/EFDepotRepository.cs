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

        public void CreateProduct(Product p)
        {
            context.Add(p);
            context.SaveChanges();
        }
        public void DeleteProduct(Product p)
        {
            context.Remove(p);
            context.SaveChanges();
        }
        public void SaveProduct(Product p)
        {
            context.SaveChanges();
        }
    }
    
    
}
