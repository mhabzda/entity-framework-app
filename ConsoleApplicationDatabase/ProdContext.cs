using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationDatabase
{
    class ProdContext : DbContext
    {
        public DbSet<Category> Categories { set; get; }
        public DbSet<Product> Products { set; get; }
        public DbSet<Customer> Customers { set; get; }
        public DbSet<Order> Orders { set; get; }
    }
}
