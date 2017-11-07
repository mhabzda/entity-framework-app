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
    public partial class AddCategoryForm : Form
    {
        ProdContext _context;
        public AddCategoryForm()
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
            if(textBox1.TextLength == 0 || textBox2.TextLength==0)
            {
                MessageBox.Show("Musisz uzupelnic pola, aby zapisac kategorie");
                return;
            }

            Category category = new Category();
            category.CategoryName = textBox1.Text;
            category.Description = textBox2.Text;

            _context.Categories.Add(category);
            _context.SaveChanges();

            Hide();
            DestroyHandle();
        }
    }
}
