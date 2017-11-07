using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationDatabase
{
    class Order
    {
        public int OrderID { get; set; }
        public string CompanyName { get; set; }
        public int ProductID { get; set; }
        public DateTime OrderDate { get; set; }
        public string OrderDetails { get; set; }
        public Customer Customer { get; set; }
        public Product Product { get; set; }
    }
}
