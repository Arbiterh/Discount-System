﻿namespace View
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
            this.discountValueMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.discountValueLabel = new System.Windows.Forms.Label();
            this.discountValueExplainLabel = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.discountTypeLabel = new System.Windows.Forms.Label();
            this.foodRadioButton = new System.Windows.Forms.RadioButton();
            this.alcoholRadioButton = new System.Windows.Forms.RadioButton();
            this.chemistryRadioButton = new System.Windows.Forms.RadioButton();
            this.allRadioButton = new System.Windows.Forms.RadioButton();
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
            this.categoryGroupBox.Controls.Add(this.allRadioButton);
            this.categoryGroupBox.Controls.Add(this.chemistryRadioButton);
            this.categoryGroupBox.Controls.Add(this.alcoholRadioButton);
            this.categoryGroupBox.Controls.Add(this.foodRadioButton);
            this.categoryGroupBox.Location = new System.Drawing.Point(12, 73);
            this.categoryGroupBox.Name = "categoryGroupBox";
            this.categoryGroupBox.Size = new System.Drawing.Size(116, 113);
            this.categoryGroupBox.TabIndex = 7;
            this.categoryGroupBox.TabStop = false;
            this.categoryGroupBox.Text = "Category of Product";
            // 
            // discountValueMaskedTextBox
            // 
            this.discountValueMaskedTextBox.Location = new System.Drawing.Point(87, 39);
            this.discountValueMaskedTextBox.Mask = "009";
            this.discountValueMaskedTextBox.Name = "discountValueMaskedTextBox";
            this.discountValueMaskedTextBox.Size = new System.Drawing.Size(41, 20);
            this.discountValueMaskedTextBox.TabIndex = 9;
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
            this.okButton.Location = new System.Drawing.Point(12, 191);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 12;
            this.okButton.Text = "Ok";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(207, 191);
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
            // foodRadioButton
            // 
            this.foodRadioButton.AutoSize = true;
            this.foodRadioButton.Location = new System.Drawing.Point(6, 42);
            this.foodRadioButton.Name = "foodRadioButton";
            this.foodRadioButton.Size = new System.Drawing.Size(49, 17);
            this.foodRadioButton.TabIndex = 0;
            this.foodRadioButton.Text = "Food";
            this.foodRadioButton.UseVisualStyleBackColor = true;
            this.foodRadioButton.CheckedChanged += new System.EventHandler(this.foodRadioButton_CheckedChanged);
            // 
            // alcoholRadioButton
            // 
            this.alcoholRadioButton.AutoSize = true;
            this.alcoholRadioButton.Location = new System.Drawing.Point(6, 65);
            this.alcoholRadioButton.Name = "alcoholRadioButton";
            this.alcoholRadioButton.Size = new System.Drawing.Size(60, 17);
            this.alcoholRadioButton.TabIndex = 1;
            this.alcoholRadioButton.Text = "Alcohol";
            this.alcoholRadioButton.UseVisualStyleBackColor = true;
            this.alcoholRadioButton.CheckedChanged += new System.EventHandler(this.alcoholRadioButton_CheckedChanged);
            // 
            // chemistryRadioButton
            // 
            this.chemistryRadioButton.AutoSize = true;
            this.chemistryRadioButton.Location = new System.Drawing.Point(6, 88);
            this.chemistryRadioButton.Name = "chemistryRadioButton";
            this.chemistryRadioButton.Size = new System.Drawing.Size(70, 17);
            this.chemistryRadioButton.TabIndex = 2;
            this.chemistryRadioButton.Text = "Chemistry";
            this.chemistryRadioButton.UseVisualStyleBackColor = true;
            this.chemistryRadioButton.CheckedChanged += new System.EventHandler(this.chemistryRadioButton_CheckedChanged);
            // 
            // allRadioButton
            // 
            this.allRadioButton.AutoSize = true;
            this.allRadioButton.Location = new System.Drawing.Point(6, 19);
            this.allRadioButton.Name = "allRadioButton";
            this.allRadioButton.Size = new System.Drawing.Size(36, 17);
            this.allRadioButton.TabIndex = 3;
            this.allRadioButton.TabStop = true;
            this.allRadioButton.Text = "All";
            this.allRadioButton.UseVisualStyleBackColor = true;
            this.allRadioButton.CheckedChanged += new System.EventHandler(this.allRadioButton_CheckedChanged);
            // 
            // DiscountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 226);
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
            this.categoryGroupBox.PerformLayout();
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
        private System.Windows.Forms.RadioButton allRadioButton;
        private System.Windows.Forms.RadioButton chemistryRadioButton;
        private System.Windows.Forms.RadioButton alcoholRadioButton;
        private System.Windows.Forms.RadioButton foodRadioButton;
    }
}