namespace View
{
    partial class DiscountForm
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
            this.discountTypeComboBox = new System.Windows.Forms.ComboBox();
            this.categoryGroupBox = new System.Windows.Forms.GroupBox();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.discountValueMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.discountValueLabel = new System.Windows.Forms.Label();
            this.discountValueExplainLabel = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.discountTypeLabel = new System.Windows.Forms.Label();
            this.categoryGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // discountTypeComboBox
            // 
            this.discountTypeComboBox.FormattingEnabled = true;
            this.discountTypeComboBox.Items.AddRange(new object[] {
            "Percent discount",
            "Sertificate discount"});
            this.discountTypeComboBox.Location = new System.Drawing.Point(87, 12);
            this.discountTypeComboBox.Name = "discountTypeComboBox";
            this.discountTypeComboBox.Size = new System.Drawing.Size(116, 21);
            this.discountTypeComboBox.TabIndex = 0;
            this.discountTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.discountTypeComboBox_SelectedIndexChanged);
            // 
            // categoryGroupBox
            // 
            this.categoryGroupBox.Controls.Add(this.categoryComboBox);
            this.categoryGroupBox.Location = new System.Drawing.Point(12, 65);
            this.categoryGroupBox.Name = "categoryGroupBox";
            this.categoryGroupBox.Size = new System.Drawing.Size(136, 46);
            this.categoryGroupBox.TabIndex = 7;
            this.categoryGroupBox.TabStop = false;
            this.categoryGroupBox.Text = "Category of Product";
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Items.AddRange(new object[] {
            "All",
            "Food",
            "Alcohol",
            "Chemistry"});
            this.categoryComboBox.Location = new System.Drawing.Point(3, 16);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(130, 21);
            this.categoryComboBox.TabIndex = 0;
            this.categoryComboBox.SelectedIndexChanged += new System.EventHandler(this.categoryComboBox_SelectedIndexChanged);
            // 
            // discountValueMaskedTextBox
            // 
            this.discountValueMaskedTextBox.Location = new System.Drawing.Point(87, 39);
            this.discountValueMaskedTextBox.Mask = "009";
            this.discountValueMaskedTextBox.Name = "discountValueMaskedTextBox";
            this.discountValueMaskedTextBox.Size = new System.Drawing.Size(41, 20);
            this.discountValueMaskedTextBox.TabIndex = 9;
            this.discountValueMaskedTextBox.TextChanged += new System.EventHandler(this.discountValueMaskedTextBox_TextChanged);
            // 
            // discountValueLabel
            // 
            this.discountValueLabel.AutoSize = true;
            this.discountValueLabel.Location = new System.Drawing.Point(9, 42);
            this.discountValueLabel.Name = "discountValueLabel";
            this.discountValueLabel.Size = new System.Drawing.Size(78, 13);
            this.discountValueLabel.TabIndex = 10;
            this.discountValueLabel.Text = "Discount value";
            // 
            // discountValueExplainLabel
            // 
            this.discountValueExplainLabel.AutoSize = true;
            this.discountValueExplainLabel.Location = new System.Drawing.Point(134, 42);
            this.discountValueExplainLabel.Name = "discountValueExplainLabel";
            this.discountValueExplainLabel.Size = new System.Drawing.Size(148, 13);
            this.discountValueExplainLabel.TabIndex = 11;
            this.discountValueExplainLabel.Text = "Input int number from 0 to 100";
            this.discountValueExplainLabel.Visible = false;
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Enabled = false;
            this.okButton.Location = new System.Drawing.Point(12, 117);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 12;
            this.okButton.Text = "Ok";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(207, 117);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 13;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // discountTypeLabel
            // 
            this.discountTypeLabel.AutoSize = true;
            this.discountTypeLabel.Location = new System.Drawing.Point(9, 15);
            this.discountTypeLabel.Name = "discountTypeLabel";
            this.discountTypeLabel.Size = new System.Drawing.Size(72, 13);
            this.discountTypeLabel.TabIndex = 15;
            this.discountTypeLabel.Text = "Discount type";
            // 
            // DiscountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 150);
            this.Controls.Add(this.discountTypeLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.discountValueExplainLabel);
            this.Controls.Add(this.discountValueLabel);
            this.Controls.Add(this.discountValueMaskedTextBox);
            this.Controls.Add(this.categoryGroupBox);
            this.Controls.Add(this.discountTypeComboBox);
            this.Name = "DiscountForm";
            this.Text = "Discount form";
            this.categoryGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox discountTypeComboBox;
        private System.Windows.Forms.GroupBox categoryGroupBox;
        private System.Windows.Forms.MaskedTextBox discountValueMaskedTextBox;
        private System.Windows.Forms.Label discountValueLabel;
        private System.Windows.Forms.Label discountValueExplainLabel;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label discountTypeLabel;
        private System.Windows.Forms.ComboBox categoryComboBox;
    }
}