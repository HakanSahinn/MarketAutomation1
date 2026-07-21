using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.EntityLayer.Concrete
{
    public class Category
    {
        public int CategoryId { get; set; }
        public String CategoryName { get; set; }
        public String CategoryDescription { get; set; }


        public virtual ICollection<Product> Products { get; set; }







    }
}
