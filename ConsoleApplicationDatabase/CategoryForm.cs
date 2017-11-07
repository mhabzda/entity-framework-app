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
    public partial class CategoryForm : Form
    {
        ProdContext _context;
        public CategoryForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            _context = new ProdContext();

            _context.Categories.Load();

            this.categoryBindingSource.DataSource =
                _context.Categories.Local.ToBindingList();
        }

        private void categoryBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();

            this._context.SaveChanges();

            this.categoryDataGridView.Refresh();
            this.productsDataGridView.Refresh();
        }

        private void categoryDataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridView dataGridView = sender as DataGridView;

            int catID = (int) dataGridView.CurrentRow.Cells[0].Value;
            var products = _context.Products
                .Where(p => p.CategoryID == catID)
                .ToList();

            this.productsBindingSource.DataSource = products;
            this.productsDataGridView.Refresh();
        }

        private void button_category_Click(object sender, EventArgs e)
        {
            AddCategoryForm form = new AddCategoryForm();
            form.Show();
        }

        private void button_product_Click(object sender, EventArgs e)
        {
            AddProductForm form = new AddProductForm();
            form.Show();
        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
            _context.Categories.Load();

            this.categoryBindingSource.DataSource =
                _context.Categories.Local.ToBindingList();
        }

        private void button_allProducts_Click(object sender, EventArgs e)
        {
            var products = _context.Products
                .ToList();

            this.productsBindingSource.DataSource = products;
            this.productsDataGridView.Refresh();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Category> categories = getCategorySortedBy(comboBox1.Text);

            this.categoryBindingSource.DataSource = categories;
            this.categoryDataGridView.Refresh();
        }

        private List<Category> getCategorySortedBy(string value)
        {
            var propertyInfo = typeof(Category).GetProperty(value);
            return _context.Categories
                .AsEnumerable()
                .OrderBy(c => propertyInfo.GetValue(c, null))
                .ToList();
        }

        private void button_orders_Click(object sender, EventArgs e)
        {
            OrdersForm form = new OrdersForm();
            form.ShowDialog();
        }
    }
}
