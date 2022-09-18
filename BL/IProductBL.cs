using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public interface IProductBL
    {
        public Task<List<Product>> GetAllBL();
        public Task<List<Product>> GetByCategoryBL(int categoryId);

        //Task<Product> PostBL(Product product);
        // Task<Product> PutBL(int id, Product product);
    }
}
