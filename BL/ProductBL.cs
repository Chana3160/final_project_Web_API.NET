using DL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class ProductBL : IProductBL
    {
        IProductDL _productDL;
        public ProductBL(IProductDL productDL)
        {
            _productDL = productDL;
        }

        public async Task<List<Product>> GetAllBL()
        {
            return await _productDL.GetAll();
        }

        public async Task<List<Product>> GetByCategoryBL(int categoryId)
        {
            return await _productDL.GetByCategory(categoryId);
        }
    }
}
