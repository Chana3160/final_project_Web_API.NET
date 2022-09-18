using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL
{
    public interface ICategoryDL
    {
        public Task<List<Category>> GetAll();
    }
}
