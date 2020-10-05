using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheDadsDepot.Models
{
    public interface IDepotRepository
    {
        IQueryable<Product> Products { get; }
    }
}
