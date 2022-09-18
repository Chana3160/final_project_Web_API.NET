using Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BL
{
    public interface IProductDL
    {
        Task<List<Product>> GetAll();
        Task<List<Product>> GetByCategory(int categoryId);
    }
}