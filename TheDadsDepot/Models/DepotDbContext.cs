using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TheDadsDepot.Models
{
    public class DepotDbContext : DbContext
    {
        public DepotDbContext(DbContextOptions<DepotDbContext> options)
            : base(options) { }

        public DbSet<Product> Products { get; set; }

    }
}
