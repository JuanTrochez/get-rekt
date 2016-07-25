using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using get_rekt.Models;

namespace get_rekt.Dao.category
{
    public interface ICategoryDao
    {
        CategoryModel getCategory(int id);
    }
}
