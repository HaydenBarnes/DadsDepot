using Microsoft.EntityFrameworkCore;
using System.Linq;
using TheDadsDepot.Migrations;

namespace TheDadsDepot.Models
{
    public interface IOrderRepository
    {
        IQueryable<Order> Orders { get; }
        void SaveOrder(Order order);
    }
}
