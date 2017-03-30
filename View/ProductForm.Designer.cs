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
            this.chemistryRadioButton = new System.Windows.Forms.RadioButton();
            this.alcoholRadioButton = new System.Windows.Forms.RadioButton();
            this.foodRadioButton = new System.Windows.Forms.RadioButton();
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
            this.basePriceMaskedTextBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.basePriceMaskedTextBox_MaskInputRejected);
            // 
            // categoryGroupBox
            // 
            this.categoryGroupBox.Controls.Add(this.chemistryRadioButton);
            this.categoryGroupBox.Controls.Add(this.alcoholRadioButton);
            this.categoryGroupBox.Controls.Add(this.foodRadioButton);
            this.categoryGroupBox.Location = new System.Drawing.Point(12, 61);
            this.categoryGroupBox.Name = "categoryGroupBox";
            this.categoryGroupBox.Size = new System.Drawing.Size(116, 98);
            this.categoryGroupBox.TabIndex = 3;
            this.categoryGroupBox.TabStop = false;
            this.categoryGroupBox.Text = "Category of Product";
            // 
            // chemistryRadioButton
            // 
            this.chemistryRadioButton.AutoSize = true;
            this.chemistryRadioButton.Location = new System.Drawing.Point(6, 66);
            this.chemistryRadioButton.Name = "chemistryRadioButton";
            this.chemistryRadioButton.Size = new System.Drawing.Size(70, 17);
            this.chemistryRadioButton.TabIndex = 2;
            this.chemistryRadioButton.Text = "Chemistry";
            this.chemistryRadioButton.UseVisualStyleBackColor = true;
            this.chemistryRadioButton.CheckedChanged += new System.EventHandler(this.chemistryRadioButton_CheckedChanged);
            // 
            // alcoholRadioButton
            // 
            this.alcoholRadioButton.AutoSize = true;
            this.alcoholRadioButton.Location = new System.Drawing.Point(6, 43);
            this.alcoholRadioButton.Name = "alcoholRadioButton";
            this.alcoholRadioButton.Size = new System.Drawing.Size(60, 17);
            this.alcoholRadioButton.TabIndex = 1;
            this.alcoholRadioButton.Text = "Alcohol";
            this.alcoholRadioButton.UseVisualStyleBackColor = true;
            this.alcoholRadioButton.CheckedChanged += new System.EventHandler(this.alcoholRadioButton_CheckedChanged);
            // 
            // foodRadioButton
            // 
            this.foodRadioButton.AutoSize = true;
            this.foodRadioButton.Location = new System.Drawing.Point(6, 20);
            this.foodRadioButton.Name = "foodRadioButton";
            this.foodRadioButton.Size = new System.Drawing.Size(49, 17);
            this.foodRadioButton.TabIndex = 0;
            this.foodRadioButton.Text = "Food";
            this.foodRadioButton.UseVisualStyleBackColor = true;
            this.foodRadioButton.CheckedChanged += new System.EventHandler(this.foodRadioButton_CheckedChanged);
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
            this.addButton.Location = new System.Drawing.Point(12, 165);
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
            this.cancelButton.Location = new System.Drawing.Point(148, 166);
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
            this.ClientSize = new System.Drawing.Size(235, 197);
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
            this.Load += new System.EventHandler(this.ProductForm_Load);
            this.categoryGroupBox.ResumeLayout(false);
            this.categoryGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MaskedTextBox basePriceMaskedTextBox;
        private System.Windows.Forms.GroupBox categoryGroupBox;
        private System.Windows.Forms.RadioButton chemistryRadioButton;
        private System.Windows.Forms.RadioButton alcoholRadioButton;
        private System.Windows.Forms.RadioButton foodRadioButton;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label basePriceLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label basePriceExplainLabel;
    }
}