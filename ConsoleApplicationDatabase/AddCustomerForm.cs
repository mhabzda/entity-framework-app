using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApplicationDatabase
{
    public partial class AddCustomerForm : Form
    {
        ProdContext _context;
        public AddCustomerForm()
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
            if (textBox2.TextLength == 0 || textBox1.TextLength == 0)
            {
                MessageBox.Show("Musisz uzupelnic pola, aby zapisac kilenta");
                return;
            }

            Customer customer = new Customer();
            customer.CompanyName = textBox1.Text;
            customer.Description = textBox2.Text;

            _context.Customers.Add(customer);
            _context.SaveChanges();

            Hide();
            DestroyHandle();
        }
    }
}
