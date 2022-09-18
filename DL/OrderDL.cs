using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL
{
    public class OrderDL : IOrderDL
    {
        salseContext _salseContext;

        public OrderDL(salseContext salseContext)
        {
            _salseContext = salseContext;
        }
        public async Task<Order> PostDL(Order order)
        {

            await _salseContext.Orders.AddAsync(order);
            await _salseContext.SaveChangesAsync();
            return order;

        }
    }
}
