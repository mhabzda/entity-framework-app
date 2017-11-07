using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApplicationDatabase
{
    public partial class MakeOrderForm : Form
    {
        ProdContext _context;
        public MakeOrderForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            _context = new ProdContext();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string companyName = textBox1.Text;
            string productName = textBox2.Text;
            if (textBox1.TextLength == 0 || textBox2.TextLength == 0)
            {
                MessageBox.Show("Musisz uzupelnic pola, aby zlozyc zamowienie");
                return;
            }

            var companies = from c in _context.Customers
                        select c.CompanyName;
            if(!isNameValid(companies, companyName))
            {
                MessageBox.Show("Niepoprawna nazwa klienta");
                return;
            }

            var products = from p in _context.Products
                        select p.Name;
            if (!isNameValid(products, productName))
            {
                MessageBox.Show("Niepoprawna nazwa produktu");
                return;
            }

            Product product = _context.Products
                .Where(p => p.Name.Equals(productName))
                .First();

            Order order = new Order();
            order.CompanyName = companyName;
            order.ProductID = product.ProductID;
            order.OrderDate = DateTime.Now;
            order.OrderDetails = textBox3.Text;

            _context.Orders.Add(order);
            _context.SaveChanges();

            Hide();
            DestroyHandle();
        }

        private bool isNameValid(IQueryable query, string name)
        {
            foreach (var queryName in query)
            {
                if (queryName.Equals(name))
                    return true;
            }
            return false;
        }
    }
}
