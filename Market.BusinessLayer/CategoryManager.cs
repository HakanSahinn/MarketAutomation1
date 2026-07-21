using Market.DataAccessLayer.Context;
using Market.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace Market.BusinessLayer
{
    public class CategoryManager
    {
        MarketContext context = new MarketContext();

        public List<Category> GetAllCategories()
        {
            var categories = context.categories.ToList();
            return categories;
        }

        public void AddCategory(Category category) { 
        
            if(!string.IsNullOrEmpty(category.CategoryName))
            {
                context.categories.Add(category);
                context.SaveChanges();

            }
        
        
        }




    }
}
