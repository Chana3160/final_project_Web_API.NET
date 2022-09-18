using Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL;


namespace DL
{
    public class CategoryDL: ICategoryDL
    {
        salseContext _salseContext;
        public CategoryDL(salseContext salseContext)
        {
            _salseContext = salseContext;
        }

        public async Task<List<Category>> GetAll()
        {
            var categoryToGet = await _salseContext.Categories.ToListAsync();

            if (categoryToGet == null)
                    return null;
            return categoryToGet;
        }
        
    }
}
