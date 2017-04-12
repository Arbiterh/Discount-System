namespace View
{
    partial class ProductForm
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
            this.basePriceMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.categoryGroupBox = new System.Windows.Forms.GroupBox();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.basePriceLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.basePriceExplainLabel = new System.Windows.Forms.Label();
            this.categoryGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // basePriceMaskedTextBox
            // 
            this.basePriceMaskedTextBox.Location = new System.Drawing.Point(75, 32);
            this.basePriceMaskedTextBox.Mask = "99990.00";
            this.basePriceMaskedTextBox.Name = "basePriceMaskedTextBox";
            this.basePriceMaskedTextBox.Size = new System.Drawing.Size(53, 20);
            this.basePriceMaskedTextBox.TabIndex = 1;
            this.basePriceMaskedTextBox.Text = "0000000";
            this.basePriceMaskedTextBox.TextChanged += new System.EventHandler(this.basePriceMaskedTextBox_TextChanged);
            // 
            // categoryGroupBox
            // 
            this.categoryGroupBox.Controls.Add(this.categoryComboBox);
            this.categoryGroupBox.Location = new System.Drawing.Point(12, 61);
            this.categoryGroupBox.Name = "categoryGroupBox";
            this.categoryGroupBox.Size = new System.Drawing.Size(116, 44);
            this.categoryGroupBox.TabIndex = 3;
            this.categoryGroupBox.TabStop = false;
            this.categoryGroupBox.Text = "Category of Product";
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Items.AddRange(new object[] {
            "Food",
            "Alcohol",
            "Chemistry"});
            this.categoryComboBox.Location = new System.Drawing.Point(3, 16);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(110, 21);
            this.categoryComboBox.TabIndex = 0;
            this.categoryComboBox.SelectedIndexChanged += new System.EventHandler(this.categoryComboBox_SelectedIndexChanged);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(12, 9);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 4;
            this.nameLabel.Text = "Name";
            // 
            // basePriceLabel
            // 
            this.basePriceLabel.AutoSize = true;
            this.basePriceLabel.Location = new System.Drawing.Point(12, 35);
            this.basePriceLabel.Name = "basePriceLabel";
            this.basePriceLabel.Size = new System.Drawing.Size(57, 13);
            this.basePriceLabel.TabIndex = 5;
            this.basePriceLabel.Text = "Base price";
            // 
            // addButton
            // 
            this.addButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.addButton.Enabled = false;
            this.addButton.Location = new System.Drawing.Point(12, 111);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 7;
            this.addButton.Text = "Add";
            this.addButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(148, 112);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 8;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(75, 6);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(148, 20);
            this.nameTextBox.TabIndex = 9;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // basePriceExplainLabel
            // 
            this.basePriceExplainLabel.AutoSize = true;
            this.basePriceExplainLabel.Location = new System.Drawing.Point(134, 35);
            this.basePriceExplainLabel.Name = "basePriceExplainLabel";
            this.basePriceExplainLabel.Size = new System.Drawing.Size(64, 13);
            this.basePriceExplainLabel.TabIndex = 10;
            this.basePriceExplainLabel.Text = "More than 0";
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 147);
            this.Controls.Add(this.basePriceExplainLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.basePriceLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.categoryGroupBox);
            this.Controls.Add(this.basePriceMaskedTextBox);
            this.Name = "ProductForm";
            this.Text = "Product form";
            this.categoryGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MaskedTextBox basePriceMaskedTextBox;
        private System.Windows.Forms.GroupBox categoryGroupBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label basePriceLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label basePriceExplainLabel;
        private System.Windows.Forms.ComboBox categoryComboBox;
    }
}