namespace ConsoleApplicationDatabase
{
    partial class CategoryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.categoryDataGridView = new System.Windows.Forms.DataGridView();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsDataGridView = new System.Windows.Forms.DataGridView();
            this.CategoryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_category = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button_orders = new System.Windows.Forms.Button();
            this.button_refresh = new System.Windows.Forms.Button();
            this.button_allProducts = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.categoryDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // categoryDataGridView
            // 
            this.categoryDataGridView.AutoGenerateColumns = false;
            this.categoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.categoryDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.categoryDataGridView.DataSource = this.categoryBindingSource;
            this.categoryDataGridView.Location = new System.Drawing.Point(169, 3);
            this.categoryDataGridView.Name = "categoryDataGridView";
            this.categoryDataGridView.Size = new System.Drawing.Size(545, 234);
            this.categoryDataGridView.TabIndex = 1;
            this.categoryDataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.categoryDataGridView_RowHeaderMouseClick);
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.categoryBindingSource;
            // 
            // productsDataGridView
            // 
            this.productsDataGridView.AutoGenerateColumns = false;
            this.productsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.CategoryID,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn8});
            this.productsDataGridView.DataSource = this.productsBindingSource;
            this.productsDataGridView.Location = new System.Drawing.Point(169, 243);
            this.productsDataGridView.Name = "productsDataGridView";
            this.productsDataGridView.Size = new System.Drawing.Size(545, 224);
            this.productsDataGridView.TabIndex = 2;
            // 
            // CategoryID
            // 
            this.CategoryID.DataPropertyName = "CategoryID";
            this.CategoryID.HeaderText = "CategoryID";
            this.CategoryID.Name = "CategoryID";
            // 
            // button_category
            // 
            this.button_category.Location = new System.Drawing.Point(33, 116);
            this.button_category.Name = "button_category";
            this.button_category.Size = new System.Drawing.Size(100, 30);
            this.button_category.TabIndex = 3;
            this.button_category.Text = "Dodaj kategorie";
            this.button_category.UseVisualStyleBackColor = true;
            this.button_category.Click += new System.EventHandler(this.button_category_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "CategoryID",
            "CategoryName",
            "Description"});
            this.comboBox1.Location = new System.Drawing.Point(22, 33);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(33, 152);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 30);
            this.button2.TabIndex = 5;
            this.button2.Text = "Dodaj produkt";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button_product_Click);
            // 
            // button_orders
            // 
            this.button_orders.Location = new System.Drawing.Point(33, 294);
            this.button_orders.Name = "button_orders";
            this.button_orders.Size = new System.Drawing.Size(100, 42);
            this.button_orders.TabIndex = 6;
            this.button_orders.Text = "Przejdz do zamowien";
            this.button_orders.UseVisualStyleBackColor = true;
            this.button_orders.Click += new System.EventHandler(this.button_orders_Click);
            // 
            // button_refresh
            // 
            this.button_refresh.Location = new System.Drawing.Point(723, 3);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(75, 51);
            this.button_refresh.TabIndex = 7;
            this.button_refresh.Text = "Odswiez liste kategorii";
            this.button_refresh.UseVisualStyleBackColor = true;
            this.button_refresh.Click += new System.EventHandler(this.button_refresh_Click);
            // 
            // button_allProducts
            // 
            this.button_allProducts.Location = new System.Drawing.Point(723, 243);
            this.button_allProducts.Name = "button_allProducts";
            this.button_allProducts.Size = new System.Drawing.Size(75, 48);
            this.button_allProducts.TabIndex = 8;
            this.button_allProducts.Text = "Pokaz wszystkie produkty";
            this.button_allProducts.UseVisualStyleBackColor = true;
            this.button_allProducts.Click += new System.EventHandler(this.button_allProducts_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(41, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Posortuj wg";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ProductID";
            this.dataGridViewTextBoxColumn4.HeaderText = "ProductID";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn5.HeaderText = "Name";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "UnitsInStock";
            this.dataGridViewTextBoxColumn6.HeaderText = "UnitsInStock";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Unitprice";
            this.dataGridViewTextBoxColumn8.HeaderText = "Unitprice";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataSource = typeof(ConsoleApplicationDatabase.Category);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CategoryID";
            this.dataGridViewTextBoxColumn1.HeaderText = "CategoryID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CategoryName";
            this.dataGridViewTextBoxColumn2.HeaderText = "CategoryName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn3.HeaderText = "Description";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = typeof(ConsoleApplicationDatabase.Order);
            // 
            // CategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 473);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_allProducts);
            this.Controls.Add(this.button_refresh);
            this.Controls.Add(this.button_orders);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button_category);
            this.Controls.Add(this.productsDataGridView);
            this.Controls.Add(this.categoryDataGridView);
            this.Name = "CategoryForm";
            this.Text = "CategoryForm";
            ((System.ComponentModel.ISupportInitialize)(this.categoryDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource categoryBindingSource;
        private System.Windows.Forms.DataGridView categoryDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private System.Windows.Forms.DataGridView productsDataGridView;
        private System.Windows.Forms.Button button_category;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button_orders;
        private System.Windows.Forms.Button button_refresh;
        private System.Windows.Forms.Button button_allProducts;
        private System.Windows.Forms.Label label1;
    }
}