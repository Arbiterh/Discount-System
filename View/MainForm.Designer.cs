namespace View
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.DiscountGroupBox = new System.Windows.Forms.GroupBox();
            this.DiscountDataGridView = new System.Windows.Forms.DataGridView();
            this.AddDiscountButton = new System.Windows.Forms.Button();
            this.RemoveDiscountButton = new System.Windows.Forms.Button();
            this.ProductGroupBox = new System.Windows.Forms.GroupBox();
            this.ProductDataGridView = new System.Windows.Forms.DataGridView();
            this.discountValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryOfProductDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDiscountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.basePriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiscountGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DiscountDataGridView)).BeginInit();
            this.ProductGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iDiscountBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DiscountGroupBox
            // 
            this.DiscountGroupBox.Controls.Add(this.DiscountDataGridView);
            this.DiscountGroupBox.Location = new System.Drawing.Point(12, 12);
            this.DiscountGroupBox.Name = "DiscountGroupBox";
            this.DiscountGroupBox.Size = new System.Drawing.Size(246, 221);
            this.DiscountGroupBox.TabIndex = 0;
            this.DiscountGroupBox.TabStop = false;
            this.DiscountGroupBox.Text = "Discount List";
            // 
            // DiscountDataGridView
            // 
            this.DiscountDataGridView.AllowUserToAddRows = false;
            this.DiscountDataGridView.AllowUserToDeleteRows = false;
            this.DiscountDataGridView.AutoGenerateColumns = false;
            this.DiscountDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DiscountDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.discountValueDataGridViewTextBoxColumn,
            this.categoryOfProductDataGridViewTextBoxColumn});
            this.DiscountDataGridView.DataSource = this.iDiscountBindingSource;
            this.DiscountDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DiscountDataGridView.Location = new System.Drawing.Point(3, 16);
            this.DiscountDataGridView.Name = "DiscountDataGridView";
            this.DiscountDataGridView.ReadOnly = true;
            this.DiscountDataGridView.Size = new System.Drawing.Size(240, 202);
            this.DiscountDataGridView.TabIndex = 0;
            this.DiscountDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // AddDiscountButton
            // 
            this.AddDiscountButton.Location = new System.Drawing.Point(15, 236);
            this.AddDiscountButton.Name = "AddDiscountButton";
            this.AddDiscountButton.Size = new System.Drawing.Size(79, 23);
            this.AddDiscountButton.TabIndex = 1;
            this.AddDiscountButton.Text = "Add Discount";
            this.AddDiscountButton.UseVisualStyleBackColor = true;
            this.AddDiscountButton.Click += new System.EventHandler(this.AddDiscountButton_Click);
            // 
            // RemoveDiscountButton
            // 
            this.RemoveDiscountButton.Location = new System.Drawing.Point(158, 236);
            this.RemoveDiscountButton.Name = "RemoveDiscountButton";
            this.RemoveDiscountButton.Size = new System.Drawing.Size(100, 23);
            this.RemoveDiscountButton.TabIndex = 2;
            this.RemoveDiscountButton.Text = "Remove Discount";
            this.RemoveDiscountButton.UseVisualStyleBackColor = true;
            this.RemoveDiscountButton.Click += new System.EventHandler(this.RemoveDiscountButton_Click);
            // 
            // ProductGroupBox
            // 
            this.ProductGroupBox.Controls.Add(this.ProductDataGridView);
            this.ProductGroupBox.Location = new System.Drawing.Point(346, 12);
            this.ProductGroupBox.Name = "ProductGroupBox";
            this.ProductGroupBox.Size = new System.Drawing.Size(269, 221);
            this.ProductGroupBox.TabIndex = 3;
            this.ProductGroupBox.TabStop = false;
            this.ProductGroupBox.Text = "Product List";
            // 
            // ProductDataGridView
            // 
            this.ProductDataGridView.AllowUserToAddRows = false;
            this.ProductDataGridView.AllowUserToDeleteRows = false;
            this.ProductDataGridView.AutoGenerateColumns = false;
            this.ProductDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.basePriceDataGridViewTextBoxColumn,
            this.resultPriceDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn});
            this.ProductDataGridView.DataSource = this.productBindingSource;
            this.ProductDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProductDataGridView.Location = new System.Drawing.Point(3, 16);
            this.ProductDataGridView.Name = "ProductDataGridView";
            this.ProductDataGridView.ReadOnly = true;
            this.ProductDataGridView.Size = new System.Drawing.Size(263, 202);
            this.ProductDataGridView.TabIndex = 0;
            // 
            // discountValueDataGridViewTextBoxColumn
            // 
            this.discountValueDataGridViewTextBoxColumn.DataPropertyName = "DiscountValue";
            this.discountValueDataGridViewTextBoxColumn.HeaderText = "Discount Value";
            this.discountValueDataGridViewTextBoxColumn.MaxInputLength = 5;
            this.discountValueDataGridViewTextBoxColumn.Name = "discountValueDataGridViewTextBoxColumn";
            this.discountValueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoryOfProductDataGridViewTextBoxColumn
            // 
            this.categoryOfProductDataGridViewTextBoxColumn.DataPropertyName = "CategoryOfProduct";
            this.categoryOfProductDataGridViewTextBoxColumn.HeaderText = "Category of product";
            this.categoryOfProductDataGridViewTextBoxColumn.Name = "categoryOfProductDataGridViewTextBoxColumn";
            this.categoryOfProductDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDiscountBindingSource
            // 
            this.iDiscountBindingSource.DataSource = typeof(BusinessLogic.IDiscount);
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(BusinessLogic.Product);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // basePriceDataGridViewTextBoxColumn
            // 
            this.basePriceDataGridViewTextBoxColumn.DataPropertyName = "BasePrice";
            this.basePriceDataGridViewTextBoxColumn.HeaderText = "BasePrice";
            this.basePriceDataGridViewTextBoxColumn.Name = "basePriceDataGridViewTextBoxColumn";
            this.basePriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // resultPriceDataGridViewTextBoxColumn
            // 
            this.resultPriceDataGridViewTextBoxColumn.DataPropertyName = "ResultPrice";
            this.resultPriceDataGridViewTextBoxColumn.HeaderText = "ResultPrice";
            this.resultPriceDataGridViewTextBoxColumn.Name = "resultPriceDataGridViewTextBoxColumn";
            this.resultPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 302);
            this.Controls.Add(this.ProductGroupBox);
            this.Controls.Add(this.RemoveDiscountButton);
            this.Controls.Add(this.AddDiscountButton);
            this.Controls.Add(this.DiscountGroupBox);
            this.Name = "MainForm";
            this.Text = "Discount System";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.DiscountGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DiscountDataGridView)).EndInit();
            this.ProductGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProductDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iDiscountBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox DiscountGroupBox;
        private System.Windows.Forms.DataGridView DiscountDataGridView;
        private System.Windows.Forms.Button AddDiscountButton;
        private System.Windows.Forms.Button RemoveDiscountButton;
        private System.Windows.Forms.BindingSource iDiscountBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn discountValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryOfProductDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox ProductGroupBox;
        private System.Windows.Forms.DataGridView ProductDataGridView;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn basePriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resultPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
    }
}

