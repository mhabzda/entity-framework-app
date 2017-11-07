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
    public partial class AddProductForm : Form
    {
        ProdContext _context;
        public AddProductForm()
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
            if (textBox1.TextLength == 0 || textBox2.TextLength == 0 || textBox3.TextLength == 0
                || textBox4.TextLength == 0)
            {
                MessageBox.Show("Musisz uzupelnic pola, aby zapisac produkt");
                return;
            }

            Product product = new Product();
            product.Name = textBox1.Text;
            product.UnitsInStock = parseToInt(textBox2.Text);
            product.CategoryID = parseToInt(textBox3.Text);
            product.Unitprice = parseToInt(textBox4.Text);

            if(product.UnitsInStock == -1 || product.CategoryID == -1 || product.Unitprice == -1)
            {
                MessageBox.Show("Zly format danych");
                return;
            }

            var query = from c in _context.Categories
                        select c.CategoryID;
            bool categoryIdvalid = false;
            foreach (var categoryID in query)
            {
                if (categoryID == product.CategoryID)
                    categoryIdvalid = true;
            }
            if(!categoryIdvalid)
            {
                MessageBox.Show("Nie mozna dodac produktu do nieistniejacej kategorii");
                return;
            }

            _context.Products.Add(product);
            _context.SaveChanges();

            Hide();
            DestroyHandle();
        }

        private int parseToInt(string text)
        {
            int val = 0;
            if (Int32.TryParse(text, out val) && val >= 0)
                return val;
            else
                return -1;
        }
    }
}
