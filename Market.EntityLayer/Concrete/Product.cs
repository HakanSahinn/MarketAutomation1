using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.EntityLayer.Concrete
{
    public class Product
    {

        public int ProductId { get; set; }
        public String ProductName { get; set; }
        public int ProductStock { get; set; }
        public decimal ProductPrice { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Categorys { get; set; }






    }
}
