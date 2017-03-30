namespace View
{
    partial class PriceListForm
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
            this.priceListGroupBox = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.basePriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addFromPriceListToCartButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.addToPriceButton = new System.Windows.Forms.Button();
            this.removeFromPriceButton = new System.Windows.Forms.Button();
            this.priceListGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceListBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // priceListGroupBox
            // 
            this.priceListGroupBox.Controls.Add(this.dataGridView1);
            this.priceListGroupBox.Location = new System.Drawing.Point(12, 12);
            this.priceListGroupBox.Name = "priceListGroupBox";
            this.priceListGroupBox.Size = new System.Drawing.Size(449, 205);
            this.priceListGroupBox.TabIndex = 0;
            this.priceListGroupBox.TabStop = false;
            this.priceListGroupBox.Text = "Price list";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.basePriceDataGridViewTextBoxColumn,
            this.resultPriceDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.priceListBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(443, 186);
            this.dataGridView1.TabIndex = 0;
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
            // priceListBindingSource
            // 
            this.priceListBindingSource.DataSource = typeof(BusinessLogic.Product);
            // 
            // addFromPriceListToCartButton
            // 
            this.addFromPriceListToCartButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.addFromPriceListToCartButton.Location = new System.Drawing.Point(15, 220);
            this.addFromPriceListToCartButton.Name = "addFromPriceListToCartButton";
            this.addFromPriceListToCartButton.Size = new System.Drawing.Size(110, 23);
            this.addFromPriceListToCartButton.TabIndex = 1;
            this.addFromPriceListToCartButton.Text = "Add selected to cart";
            this.addFromPriceListToCartButton.UseVisualStyleBackColor = true;
            this.addFromPriceListToCartButton.Click += new System.EventHandler(this.addFromPriceListToCartButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeButton.Location = new System.Drawing.Point(383, 220);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 2;
            this.closeButton.Text = "Cancel";
            this.closeButton.UseVisualStyleBackColor = true;
            // 
            // addToPriceButton
            // 
            this.addToPriceButton.Location = new System.Drawing.Point(131, 220);
            this.addToPriceButton.Name = "addToPriceButton";
            this.addToPriceButton.Size = new System.Drawing.Size(75, 23);
            this.addToPriceButton.TabIndex = 3;
            this.addToPriceButton.Text = "Add position";
            this.addToPriceButton.UseVisualStyleBackColor = true;
            this.addToPriceButton.Visible = false;
            this.addToPriceButton.Click += new System.EventHandler(this.addToPriceButton_Click);
            // 
            // removeFromPriceButton
            // 
            this.removeFromPriceButton.Location = new System.Drawing.Point(212, 220);
            this.removeFromPriceButton.Name = "removeFromPriceButton";
            this.removeFromPriceButton.Size = new System.Drawing.Size(139, 23);
            this.removeFromPriceButton.TabIndex = 4;
            this.removeFromPriceButton.Text = "Remove selected position";
            this.removeFromPriceButton.UseVisualStyleBackColor = true;
            this.removeFromPriceButton.Visible = false;
            this.removeFromPriceButton.Click += new System.EventHandler(this.removeFromPriceButton_Click);
            // 
            // PriceListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 253);
            this.Controls.Add(this.removeFromPriceButton);
            this.Controls.Add(this.addToPriceButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.addFromPriceListToCartButton);
            this.Controls.Add(this.priceListGroupBox);
            this.Name = "PriceListForm";
            this.Text = "Price list form";
            this.Load += new System.EventHandler(this.PriceListForm_Load);
            this.priceListGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceListBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox priceListGroupBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource priceListBindingSource;
        private System.Windows.Forms.Button addFromPriceListToCartButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn basePriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resultPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button addToPriceButton;
        private System.Windows.Forms.Button removeFromPriceButton;
    }
}