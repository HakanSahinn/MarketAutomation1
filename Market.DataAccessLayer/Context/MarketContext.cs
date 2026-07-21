using Market.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.DataAccessLayer.Context
{
    public class MarketContext : DbContext
    {

        public DbSet <Category> categories { get; set; }
        public DbSet <Product> products { get; set; }





    }
}
