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
    public partial class OrdersForm : Form
    {
        ProdContext _context;
        public OrdersForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            _context = new ProdContext();

            _context.Orders.Load();

            this.orderBindingSource.DataSource =
                _context.Orders.Local.ToBindingList();
        }

        private void orderDataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridView dataGridView = sender as DataGridView;
            string companyName = (string)dataGridView.CurrentRow.Cells[1].Value;
            int productID = (int)dataGridView.CurrentRow.Cells[2].Value;

            Order order = _context.Orders
                .Include(o => o.Product)
                .Include(o => o.Customer)
                .Where(o => o.CompanyName == companyName && o.ProductID == productID)
                .First();

            Category category = _context.Categories
                .Where(c => c.CategoryID == order.Product.CategoryID)
                .First();

            ListViewItem item = new ListViewItem(order.CompanyName);
            item.SubItems.Add(order.Customer.Description);
            item.SubItems.Add(order.Product.Name);
            item.SubItems.Add(category.CategoryName);

            listView1.Items.Clear();
            listView1.Items.Add(item);
        }

        private void button_makeOrder_Click(object sender, EventArgs e)
        {
            MakeOrderForm form = new MakeOrderForm();
            form.ShowDialog();
        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
            _context.Orders.Load();

            this.orderBindingSource.DataSource =
                _context.Orders.Local.ToBindingList();
        }

        private void button_customer_Click(object sender, EventArgs e)
        {
            AddCustomerForm form = new AddCustomerForm();
            form.ShowDialog();
        }
    }
}
