using Market.DataAccessLayer.Context;
using Market.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.BusinessLayer
{
    public class ProductManager
    {
        MarketContext context =new MarketContext();

        public List<Product> GetAllProducts()
        {
            return context.products.ToList();
        }

        public void AddProduct(Product product)
        {
            context.products.Add(product);
            context.SaveChanges();
        }
        public void UpdateProduct(Product product)
        {
            var existingProduct = context.products.Find(product.ProductId);
            if (existingProduct != null)
            {
                existingProduct.ProductName = product.ProductName;
                existingProduct.ProductPrice = product.ProductPrice;
                existingProduct.ProductStock = product.ProductStock;
                existingProduct.CategoryId = product.CategoryId;
                context.SaveChanges();
            }
        }
        public void DeleteProduct(int productId)
        {
            var product = context.products.Find(productId);
            if (product != null)
            {
                context.products.Remove(product);
                context.SaveChanges();
            }
        }


    }
}
