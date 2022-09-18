using DL;
using Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ILogger = NLog.ILogger;

namespace BL
{

    public class OrderBL : IOrderBL
    {
        IOrderDL _orderDL;
        salseContext _salseContext;
        private int? quntity;

        public OrderBL(IOrderDL orderDL, salseContext salseContext)
        {
            _orderDL = orderDL;
            _salseContext = salseContext;
        }
        public async Task<Order> PostBL(Order order)
        {
            checkSum(order);
            var order1 = await _orderDL.PostDL(order);
            if (order1 == null)
                return null;
            return order1;
        }


        public async void checkSum(Order order)
        {
            //using (var context = new salseContext())
            //{
            //    string sum = " ";
            //    foreach(Product product in order.OrderItems)
            //    {
            //        Product prod = await context.Products.Where(p => p.ProductId == product.ProductId).FirstOrDefaultAsync();
            //        int quntity = await order.OrderItems.Where(p => p.ProductId == product.ProductId).FirstOrDefaultAsync().Quantity;
            //        sum += prod.PriceProduct * quntity;
            //    }
            //    //לא עובד לנו בגלל שהמחיר שלנו  מוגדר כסטירנג
            //  //   order.Price -= 50;
            //    if (sum != order.Price)
            //    {
            //        ILogger.LogInformation("the user " + order.User + " try to change the price of the order,please note!!");
            //        order.Price = sum;
            //        await context.SaveChangesAsync();
            //    }
            //}
        }

    }
 }

