using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using get_rekt.Models;

namespace get_rekt.Dao.category
{
    public class CategoryDaoDb : ICategoryDao
    {
        public CategoryDaoDb() { }
        public CategoryModel getCategory(int id)
        {
            Context contextCategory = new Context();

            CategoryModel category = contextCategory.Categories
                .Where(c => c.Id == id)
                .FirstOrDefault();

            return category;
        }

        public static List<CategoryModel> getAllCategories()
        {
            Context contextCategory = new Context();

            List<CategoryModel> categories = contextCategory.Categories.ToList();

            return categories;
        }
    }
}