using BL;
using Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL
{
    public class ProductDL : IProductDL
    {
        salseContext _salseContext;
        public ProductDL(salseContext salseContext)
        {
            _salseContext = salseContext;
        }
        public async Task<List<Product>> GetAll()
        {
            var productsToGet = await _salseContext.Products.ToListAsync();
                
            if (productsToGet == null)
                return null; 
            return productsToGet;
        }

        public async Task<List<Product>> GetByCategory(int categoryId)
        {
            var productsToGet = await _salseContext.Products.Where(p=>p.CategoryId==categoryId).ToListAsync();
           
            if (productsToGet == null)
                return null;
            return productsToGet;
        }

       
    }
}
