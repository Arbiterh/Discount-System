namespace View
{
    partial class DiscountListForm
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
            this.discountListGroupBox = new System.Windows.Forms.GroupBox();
            this.discountListDataGridView = new System.Windows.Forms.DataGridView();
            this.iDiscountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addButton = new System.Windows.Forms.Button();
            this.modifyButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discountClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discountValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryOfProductDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discountListGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.discountListDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iDiscountBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // discountListGroupBox
            // 
            this.discountListGroupBox.Controls.Add(this.discountListDataGridView);
            this.discountListGroupBox.Location = new System.Drawing.Point(12, 12);
            this.discountListGroupBox.Name = "discountListGroupBox";
            this.discountListGroupBox.Size = new System.Drawing.Size(420, 185);
            this.discountListGroupBox.TabIndex = 0;
            this.discountListGroupBox.TabStop = false;
            this.discountListGroupBox.Text = "Discount list";
            // 
            // discountListDataGridView
            // 
            this.discountListDataGridView.AllowUserToAddRows = false;
            this.discountListDataGridView.AllowUserToDeleteRows = false;
            this.discountListDataGridView.AutoGenerateColumns = false;
            this.discountListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.discountListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColumn,
            this.discountClass,
            this.discountValueDataGridViewTextBoxColumn,
            this.categoryOfProductDataGridViewTextBoxColumn});
            this.discountListDataGridView.DataSource = this.iDiscountBindingSource;
            this.discountListDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.discountListDataGridView.Location = new System.Drawing.Point(3, 16);
            this.discountListDataGridView.Name = "discountListDataGridView";
            this.discountListDataGridView.ReadOnly = true;
            this.discountListDataGridView.Size = new System.Drawing.Size(414, 166);
            this.discountListDataGridView.TabIndex = 0;
            // 
            // iDiscountBindingSource
            // 
            this.iDiscountBindingSource.DataSource = typeof(BusinessLogic.IDiscount);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(15, 203);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(56, 23);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // modifyButton
            // 
            this.modifyButton.Location = new System.Drawing.Point(77, 203);
            this.modifyButton.Name = "modifyButton";
            this.modifyButton.Size = new System.Drawing.Size(59, 23);
            this.modifyButton.TabIndex = 2;
            this.modifyButton.Text = "Modify";
            this.modifyButton.UseVisualStyleBackColor = true;
            this.modifyButton.Click += new System.EventHandler(this.modifyButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(142, 203);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(102, 23);
            this.removeButton.TabIndex = 3;
            this.removeButton.Text = "Remove selected";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(249, 203);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(102, 23);
            this.clearButton.TabIndex = 4;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(357, 203);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(72, 23);
            this.closeButton.TabIndex = 5;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // idColumn
            // 
            this.idColumn.Frozen = true;
            this.idColumn.HeaderText = "Id";
            this.idColumn.Name = "idColumn";
            this.idColumn.ReadOnly = true;
            this.idColumn.Width = 40;
            // 
            // discountClass
            // 
            this.discountClass.Frozen = true;
            this.discountClass.HeaderText = "Type of discount";
            this.discountClass.Name = "discountClass";
            this.discountClass.ReadOnly = true;
            // 
            // discountValueDataGridViewTextBoxColumn
            // 
            this.discountValueDataGridViewTextBoxColumn.DataPropertyName = "DiscountValue";
            this.discountValueDataGridViewTextBoxColumn.Frozen = true;
            this.discountValueDataGridViewTextBoxColumn.HeaderText = "Discount value";
            this.discountValueDataGridViewTextBoxColumn.Name = "discountValueDataGridViewTextBoxColumn";
            this.discountValueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoryOfProductDataGridViewTextBoxColumn
            // 
            this.categoryOfProductDataGridViewTextBoxColumn.DataPropertyName = "CategoryOfProduct";
            this.categoryOfProductDataGridViewTextBoxColumn.Frozen = true;
            this.categoryOfProductDataGridViewTextBoxColumn.HeaderText = "Category of product";
            this.categoryOfProductDataGridViewTextBoxColumn.Name = "categoryOfProductDataGridViewTextBoxColumn";
            this.categoryOfProductDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // DiscountListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 239);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.modifyButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.discountListGroupBox);
            this.Name = "DiscountListForm";
            this.Text = "Discount list form";
            this.Load += new System.EventHandler(this.DiscountListForm_Load);
            this.discountListGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.discountListDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iDiscountBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox discountListGroupBox;
        private System.Windows.Forms.DataGridView discountListDataGridView;
        public System.Windows.Forms.BindingSource iDiscountBindingSource;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button modifyButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn discountClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn discountValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryOfProductDataGridViewTextBoxColumn;
    }
}