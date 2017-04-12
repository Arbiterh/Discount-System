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
            this.busketGroupBox = new System.Windows.Forms.GroupBox();
            this.cartDataGridView = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.basePriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.discountGroupBox = new System.Windows.Forms.GroupBox();
            this.checkDiscountButton = new System.Windows.Forms.Button();
            this.resultCheckingDiscountNumberLabel = new System.Windows.Forms.Label();
            this.discountNumberMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.addFromProductListButton = new System.Windows.Forms.Button();
            this.removeFromCartButton = new System.Windows.Forms.Button();
            this.resultButton = new System.Windows.Forms.Button();
            this.clearCartButton = new System.Windows.Forms.Button();
            this.showDiscountFormButton = new System.Windows.Forms.Button();
            this.cartSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.cartOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.fileMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.busketGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cartDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.discountGroupBox.SuspendLayout();
            this.fileMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // busketGroupBox
            // 
            this.busketGroupBox.Controls.Add(this.cartDataGridView);
            this.busketGroupBox.Location = new System.Drawing.Point(12, 27);
            this.busketGroupBox.Name = "busketGroupBox";
            this.busketGroupBox.Size = new System.Drawing.Size(449, 234);
            this.busketGroupBox.TabIndex = 0;
            this.busketGroupBox.TabStop = false;
            this.busketGroupBox.Text = "Your shopping cart";
            // 
            // cartDataGridView
            // 
            this.cartDataGridView.AllowUserToAddRows = false;
            this.cartDataGridView.AllowUserToDeleteRows = false;
            this.cartDataGridView.AutoGenerateColumns = false;
            this.cartDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cartDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.basePriceDataGridViewTextBoxColumn,
            this.resultPriceDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn});
            this.cartDataGridView.DataSource = this.productBindingSource;
            this.cartDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cartDataGridView.Location = new System.Drawing.Point(3, 16);
            this.cartDataGridView.Name = "cartDataGridView";
            this.cartDataGridView.ReadOnly = true;
            this.cartDataGridView.Size = new System.Drawing.Size(443, 215);
            this.cartDataGridView.TabIndex = 0;
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
            this.basePriceDataGridViewTextBoxColumn.HeaderText = "Base price";
            this.basePriceDataGridViewTextBoxColumn.Name = "basePriceDataGridViewTextBoxColumn";
            this.basePriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // resultPriceDataGridViewTextBoxColumn
            // 
            this.resultPriceDataGridViewTextBoxColumn.DataPropertyName = "ResultPrice";
            this.resultPriceDataGridViewTextBoxColumn.HeaderText = "Result price";
            this.resultPriceDataGridViewTextBoxColumn.Name = "resultPriceDataGridViewTextBoxColumn";
            this.resultPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Category";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(BusinessLogic.Product);
            // 
            // discountGroupBox
            // 
            this.discountGroupBox.Controls.Add(this.checkDiscountButton);
            this.discountGroupBox.Controls.Add(this.resultCheckingDiscountNumberLabel);
            this.discountGroupBox.Controls.Add(this.discountNumberMaskedTextBox);
            this.discountGroupBox.Location = new System.Drawing.Point(469, 27);
            this.discountGroupBox.Name = "discountGroupBox";
            this.discountGroupBox.Size = new System.Drawing.Size(136, 57);
            this.discountGroupBox.TabIndex = 1;
            this.discountGroupBox.TabStop = false;
            this.discountGroupBox.Text = "Input Discount Code";
            // 
            // checkDiscountButton
            // 
            this.checkDiscountButton.Location = new System.Drawing.Point(37, 17);
            this.checkDiscountButton.Name = "checkDiscountButton";
            this.checkDiscountButton.Size = new System.Drawing.Size(89, 23);
            this.checkDiscountButton.TabIndex = 10;
            this.checkDiscountButton.Text = "Check discount";
            this.checkDiscountButton.UseVisualStyleBackColor = true;
            this.checkDiscountButton.Click += new System.EventHandler(this.checkDiscountButton_Click);
            // 
            // resultCheckingDiscountNumberLabel
            // 
            this.resultCheckingDiscountNumberLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultCheckingDiscountNumberLabel.AutoSize = true;
            this.resultCheckingDiscountNumberLabel.Location = new System.Drawing.Point(3, 42);
            this.resultCheckingDiscountNumberLabel.Name = "resultCheckingDiscountNumberLabel";
            this.resultCheckingDiscountNumberLabel.Size = new System.Drawing.Size(37, 13);
            this.resultCheckingDiscountNumberLabel.TabIndex = 1;
            this.resultCheckingDiscountNumberLabel.Text = "Result";
            this.resultCheckingDiscountNumberLabel.Visible = false;
            // 
            // discountNumberMaskedTextBox
            // 
            this.discountNumberMaskedTextBox.Location = new System.Drawing.Point(6, 19);
            this.discountNumberMaskedTextBox.Mask = "009";
            this.discountNumberMaskedTextBox.Name = "discountNumberMaskedTextBox";
            this.discountNumberMaskedTextBox.Size = new System.Drawing.Size(25, 20);
            this.discountNumberMaskedTextBox.TabIndex = 0;
            // 
            // addFromProductListButton
            // 
            this.addFromProductListButton.Location = new System.Drawing.Point(10, 267);
            this.addFromProductListButton.Name = "addFromProductListButton";
            this.addFromProductListButton.Size = new System.Drawing.Size(137, 23);
            this.addFromProductListButton.TabIndex = 2;
            this.addFromProductListButton.Text = "Add product from price list";
            this.addFromProductListButton.UseVisualStyleBackColor = true;
            this.addFromProductListButton.Click += new System.EventHandler(this.addFromProductListButton_Click);
            // 
            // removeFromCartButton
            // 
            this.removeFromCartButton.Location = new System.Drawing.Point(153, 267);
            this.removeFromCartButton.Name = "removeFromCartButton";
            this.removeFromCartButton.Size = new System.Drawing.Size(143, 23);
            this.removeFromCartButton.TabIndex = 3;
            this.removeFromCartButton.Text = "Remove selected from cart";
            this.removeFromCartButton.UseVisualStyleBackColor = true;
            this.removeFromCartButton.Click += new System.EventHandler(this.removeFromBasketButton_Click);
            // 
            // resultButton
            // 
            this.resultButton.Location = new System.Drawing.Point(412, 267);
            this.resultButton.Name = "resultButton";
            this.resultButton.Size = new System.Drawing.Size(46, 23);
            this.resultButton.TabIndex = 4;
            this.resultButton.Text = "Total";
            this.resultButton.UseVisualStyleBackColor = true;
            this.resultButton.Click += new System.EventHandler(this.resultButton_Click);
            // 
            // clearCartButton
            // 
            this.clearCartButton.Location = new System.Drawing.Point(302, 267);
            this.clearCartButton.Name = "clearCartButton";
            this.clearCartButton.Size = new System.Drawing.Size(62, 23);
            this.clearCartButton.TabIndex = 5;
            this.clearCartButton.Text = "Clear cart";
            this.clearCartButton.UseVisualStyleBackColor = true;
            this.clearCartButton.Click += new System.EventHandler(this.clearCartButton_Click);
            // 
            // showDiscountFormButton
            // 
            this.showDiscountFormButton.Location = new System.Drawing.Point(472, 90);
            this.showDiscountFormButton.Name = "showDiscountFormButton";
            this.showDiscountFormButton.Size = new System.Drawing.Size(133, 23);
            this.showDiscountFormButton.TabIndex = 6;
            this.showDiscountFormButton.Text = "Operate with discount list";
            this.showDiscountFormButton.UseVisualStyleBackColor = true;
            this.showDiscountFormButton.Visible = false;
            this.showDiscountFormButton.Click += new System.EventHandler(this.showDiscountFormButton_Click);
            // 
            // cartSaveFileDialog
            // 
            this.cartSaveFileDialog.CheckFileExists = true;
            this.cartSaveFileDialog.CreatePrompt = true;
            this.cartSaveFileDialog.FileName = "your_cart.dss";
            this.cartSaveFileDialog.InitialDirectory = "C:\\DS_data\\ProductList";
            // 
            // cartOpenFileDialog
            // 
            this.cartOpenFileDialog.FileName = "your_cart.dss";
            this.cartOpenFileDialog.InitialDirectory = "C:\\DS_data\\ProductList";
            // 
            // fileMenuStrip
            // 
            this.fileMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.fileMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.fileMenuStrip.Name = "fileMenuStrip";
            this.fileMenuStrip.Size = new System.Drawing.Size(617, 24);
            this.fileMenuStrip.TabIndex = 9;
            this.fileMenuStrip.Text = "fileMenuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 302);
            this.Controls.Add(this.showDiscountFormButton);
            this.Controls.Add(this.clearCartButton);
            this.Controls.Add(this.resultButton);
            this.Controls.Add(this.removeFromCartButton);
            this.Controls.Add(this.addFromProductListButton);
            this.Controls.Add(this.discountGroupBox);
            this.Controls.Add(this.busketGroupBox);
            this.Controls.Add(this.fileMenuStrip);
            this.Name = "MainForm";
            this.Text = "Discount System";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.busketGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cartDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.discountGroupBox.ResumeLayout(false);
            this.discountGroupBox.PerformLayout();
            this.fileMenuStrip.ResumeLayout(false);
            this.fileMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox busketGroupBox;
        private System.Windows.Forms.DataGridView cartDataGridView;
        private System.Windows.Forms.GroupBox discountGroupBox;
        private System.Windows.Forms.Label resultCheckingDiscountNumberLabel;
        private System.Windows.Forms.MaskedTextBox discountNumberMaskedTextBox;
        private System.Windows.Forms.Button addFromProductListButton;
        private System.Windows.Forms.Button removeFromCartButton;
        private System.Windows.Forms.Button resultButton;
        private System.Windows.Forms.Button clearCartButton;
        private System.Windows.Forms.Button showDiscountFormButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn basePriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resultPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.SaveFileDialog cartSaveFileDialog;
        private System.Windows.Forms.OpenFileDialog cartOpenFileDialog;
        private System.Windows.Forms.MenuStrip fileMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.Button checkDiscountButton;
    }
}

