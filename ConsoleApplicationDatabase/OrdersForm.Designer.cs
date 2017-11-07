namespace ConsoleApplicationDatabase
{
    partial class OrdersForm
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
            this.orderDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button_makeOrder = new System.Windows.Forms.Button();
            this.button_refresh = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.companyName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.companyInfo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.productName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.categoryName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.button_customer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.orderDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // orderDataGridView
            // 
            this.orderDataGridView.AutoGenerateColumns = false;
            this.orderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.orderDataGridView.DataSource = this.orderBindingSource;
            this.orderDataGridView.Location = new System.Drawing.Point(139, 4);
            this.orderDataGridView.Name = "orderDataGridView";
            this.orderDataGridView.Size = new System.Drawing.Size(544, 361);
            this.orderDataGridView.TabIndex = 1;
            this.orderDataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.orderDataGridView_RowHeaderMouseClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "OrderID";
            this.dataGridViewTextBoxColumn1.HeaderText = "OrderID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CompanyName";
            this.dataGridViewTextBoxColumn2.HeaderText = "CompanyName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ProductID";
            this.dataGridViewTextBoxColumn3.HeaderText = "ProductID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "OrderDate";
            this.dataGridViewTextBoxColumn4.HeaderText = "OrderDate";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "OrderDetails";
            this.dataGridViewTextBoxColumn5.HeaderText = "OrderDetails";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = typeof(ConsoleApplicationDatabase.Order);
            // 
            // button_makeOrder
            // 
            this.button_makeOrder.Location = new System.Drawing.Point(30, 145);
            this.button_makeOrder.Name = "button_makeOrder";
            this.button_makeOrder.Size = new System.Drawing.Size(78, 38);
            this.button_makeOrder.TabIndex = 2;
            this.button_makeOrder.Text = "Zloz zamowienie";
            this.button_makeOrder.UseVisualStyleBackColor = true;
            this.button_makeOrder.Click += new System.EventHandler(this.button_makeOrder_Click);
            // 
            // button_refresh
            // 
            this.button_refresh.Location = new System.Drawing.Point(30, 28);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(78, 38);
            this.button_refresh.TabIndex = 3;
            this.button_refresh.Text = "Odwiez liste zamowien";
            this.button_refresh.UseVisualStyleBackColor = true;
            this.button_refresh.Click += new System.EventHandler(this.button_refresh_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.companyName,
            this.companyInfo,
            this.productName,
            this.categoryName});
            this.listView1.Location = new System.Drawing.Point(139, 390);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(544, 57);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // companyName
            // 
            this.companyName.Text = "CompanyName";
            this.companyName.Width = 118;
            // 
            // companyInfo
            // 
            this.companyInfo.Text = "CompanyDescription";
            this.companyInfo.Width = 158;
            // 
            // productName
            // 
            this.productName.Text = "ProductName";
            this.productName.Width = 137;
            // 
            // categoryName
            // 
            this.categoryName.Text = "CategoryName";
            this.categoryName.Width = 122;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(147, 370);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Order Info:";
            // 
            // button_customer
            // 
            this.button_customer.Location = new System.Drawing.Point(30, 225);
            this.button_customer.Name = "button_customer";
            this.button_customer.Size = new System.Drawing.Size(78, 29);
            this.button_customer.TabIndex = 6;
            this.button_customer.Text = "Dodaj klienta";
            this.button_customer.UseVisualStyleBackColor = true;
            this.button_customer.Click += new System.EventHandler(this.button_customer_Click);
            // 
            // OrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 460);
            this.Controls.Add(this.button_customer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button_refresh);
            this.Controls.Add(this.button_makeOrder);
            this.Controls.Add(this.orderDataGridView);
            this.Name = "OrdersForm";
            this.Text = "OrdersForm";
            ((System.ComponentModel.ISupportInitialize)(this.orderDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource orderBindingSource;
        private System.Windows.Forms.DataGridView orderDataGridView;
        private System.Windows.Forms.Button button_makeOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button button_refresh;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader companyInfo;
        private System.Windows.Forms.ColumnHeader productName;
        private System.Windows.Forms.ColumnHeader categoryName;
        private System.Windows.Forms.ColumnHeader companyName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_customer;
    }
}