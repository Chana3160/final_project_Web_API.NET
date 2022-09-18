using DL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class CategoryBL:ICategoryBL
    {
        ICategoryDL _categoryDL;
        public CategoryBL(ICategoryDL categoryDL)
        {
            _categoryDL = categoryDL;
        }

        public async Task<List<Category>> GetAllBL()
        {
            return await _categoryDL.GetAll();
        }

    }
}
