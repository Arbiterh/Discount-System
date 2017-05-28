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
            this.priceListDataGridView = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.basePriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addFromPriceListToCartButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.addToPriceButton = new System.Windows.Forms.Button();
            this.removeFromPriceButton = new System.Windows.Forms.Button();
            this.fileMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.priceSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.priceOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.randomButton = new System.Windows.Forms.Button();
            this.priceListGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.priceListDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceListBindingSource)).BeginInit();
            this.fileMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // priceListGroupBox
            // 
            this.priceListGroupBox.Controls.Add(this.priceListDataGridView);
            this.priceListGroupBox.Location = new System.Drawing.Point(12, 27);
            this.priceListGroupBox.Name = "priceListGroupBox";
            this.priceListGroupBox.Size = new System.Drawing.Size(449, 205);
            this.priceListGroupBox.TabIndex = 0;
            this.priceListGroupBox.TabStop = false;
            this.priceListGroupBox.Text = "Price list";
            // 
            // priceListDataGridView
            // 
            this.priceListDataGridView.AllowUserToAddRows = false;
            this.priceListDataGridView.AllowUserToDeleteRows = false;
            this.priceListDataGridView.AutoGenerateColumns = false;
            this.priceListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.priceListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.basePriceDataGridViewTextBoxColumn,
            this.resultPriceDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn});
            this.priceListDataGridView.DataSource = this.priceListBindingSource;
            this.priceListDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.priceListDataGridView.Location = new System.Drawing.Point(3, 16);
            this.priceListDataGridView.Name = "priceListDataGridView";
            this.priceListDataGridView.ReadOnly = true;
            this.priceListDataGridView.Size = new System.Drawing.Size(443, 186);
            this.priceListDataGridView.TabIndex = 0;
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
            this.addFromPriceListToCartButton.Location = new System.Drawing.Point(15, 235);
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
            this.closeButton.Location = new System.Drawing.Point(383, 235);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 2;
            this.closeButton.Text = "Cancel";
            this.closeButton.UseVisualStyleBackColor = true;
            // 
            // addToPriceButton
            // 
            this.addToPriceButton.Location = new System.Drawing.Point(131, 235);
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
            this.removeFromPriceButton.Location = new System.Drawing.Point(212, 235);
            this.removeFromPriceButton.Name = "removeFromPriceButton";
            this.removeFromPriceButton.Size = new System.Drawing.Size(139, 23);
            this.removeFromPriceButton.TabIndex = 4;
            this.removeFromPriceButton.Text = "Remove selected position";
            this.removeFromPriceButton.UseVisualStyleBackColor = true;
            this.removeFromPriceButton.Visible = false;
            this.removeFromPriceButton.Click += new System.EventHandler(this.removeFromPriceButton_Click);
            // 
            // fileMenuStrip
            // 
            this.fileMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.fileMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.fileMenuStrip.Name = "fileMenuStrip";
            this.fileMenuStrip.Size = new System.Drawing.Size(475, 24);
            this.fileMenuStrip.TabIndex = 5;
            this.fileMenuStrip.Text = "menuStrip1";
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
            // priceSaveFileDialog
            // 
            this.priceSaveFileDialog.FileName = "PriceList.dss";
            this.priceSaveFileDialog.InitialDirectory = "C:\\DS_data\\PriceList";
            // 
            // priceOpenFileDialog
            // 
            this.priceOpenFileDialog.FileName = "PriceList.dss";
            this.priceOpenFileDialog.InitialDirectory = "C:\\DS_data\\PriceList";
            // 
            // randomButton
            // 
            this.randomButton.Location = new System.Drawing.Point(358, 235);
            this.randomButton.Name = "randomButton";
            this.randomButton.Size = new System.Drawing.Size(19, 23);
            this.randomButton.TabIndex = 6;
            this.randomButton.Text = "Rnd";
            this.randomButton.UseVisualStyleBackColor = true;
            this.randomButton.Visible = false;
            this.randomButton.Click += new System.EventHandler(this.randomButton_Click);
            // 
            // PriceListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 270);
            this.Controls.Add(this.randomButton);
            this.Controls.Add(this.removeFromPriceButton);
            this.Controls.Add(this.addToPriceButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.addFromPriceListToCartButton);
            this.Controls.Add(this.priceListGroupBox);
            this.Controls.Add(this.fileMenuStrip);
            this.MainMenuStrip = this.fileMenuStrip;
            this.Name = "PriceListForm";
            this.Text = "Price list form";
            this.Load += new System.EventHandler(this.PriceListForm_Load);
            this.priceListGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.priceListDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceListBindingSource)).EndInit();
            this.fileMenuStrip.ResumeLayout(false);
            this.fileMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox priceListGroupBox;
        private System.Windows.Forms.DataGridView priceListDataGridView;
        private System.Windows.Forms.BindingSource priceListBindingSource;
        private System.Windows.Forms.Button addFromPriceListToCartButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn basePriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resultPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button addToPriceButton;
        private System.Windows.Forms.Button removeFromPriceButton;
        private System.Windows.Forms.MenuStrip fileMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog priceSaveFileDialog;
        private System.Windows.Forms.OpenFileDialog priceOpenFileDialog;
        private System.Windows.Forms.Button randomButton;
    }
}