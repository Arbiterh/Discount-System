namespace View.Controls
{
    partial class DiscountControl
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.discountTypeLabel = new System.Windows.Forms.Label();
            this.discountValueExplainLabel = new System.Windows.Forms.Label();
            this.discountValueLabel = new System.Windows.Forms.Label();
            this.discountValueMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.discountTypeComboBox = new System.Windows.Forms.ComboBox();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.categoryGroupBox = new System.Windows.Forms.GroupBox();
            this.categoryGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // discountTypeLabel
            // 
            this.discountTypeLabel.AutoSize = true;
            this.discountTypeLabel.Location = new System.Drawing.Point(3, 5);
            this.discountTypeLabel.Name = "discountTypeLabel";
            this.discountTypeLabel.Size = new System.Drawing.Size(72, 13);
            this.discountTypeLabel.TabIndex = 21;
            this.discountTypeLabel.Text = "Discount type";
            // 
            // discountValueExplainLabel
            // 
            this.discountValueExplainLabel.AutoSize = true;
            this.discountValueExplainLabel.Location = new System.Drawing.Point(128, 32);
            this.discountValueExplainLabel.Name = "discountValueExplainLabel";
            this.discountValueExplainLabel.Size = new System.Drawing.Size(148, 13);
            this.discountValueExplainLabel.TabIndex = 20;
            this.discountValueExplainLabel.Text = "Input int number from 0 to 100";
            this.discountValueExplainLabel.Visible = false;
            // 
            // discountValueLabel
            // 
            this.discountValueLabel.AutoSize = true;
            this.discountValueLabel.Location = new System.Drawing.Point(3, 32);
            this.discountValueLabel.Name = "discountValueLabel";
            this.discountValueLabel.Size = new System.Drawing.Size(78, 13);
            this.discountValueLabel.TabIndex = 19;
            this.discountValueLabel.Text = "Discount value";
            // 
            // discountValueMaskedTextBox
            // 
            this.discountValueMaskedTextBox.Enabled = false;
            this.discountValueMaskedTextBox.Location = new System.Drawing.Point(81, 29);
            this.discountValueMaskedTextBox.Mask = "009";
            this.discountValueMaskedTextBox.Name = "discountValueMaskedTextBox";
            this.discountValueMaskedTextBox.Size = new System.Drawing.Size(41, 20);
            this.discountValueMaskedTextBox.TabIndex = 18;
            this.discountValueMaskedTextBox.TextChanged += new System.EventHandler(this.discountValueMaskedTextBox_TextChanged);
            // 
            // discountTypeComboBox
            // 
            this.discountTypeComboBox.FormattingEnabled = true;
            this.discountTypeComboBox.Items.AddRange(new object[] {
            "Percent discount",
            "Sertificate discount"});
            this.discountTypeComboBox.Location = new System.Drawing.Point(81, 2);
            this.discountTypeComboBox.Name = "discountTypeComboBox";
            this.discountTypeComboBox.Size = new System.Drawing.Size(116, 21);
            this.discountTypeComboBox.TabIndex = 16;
            this.discountTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.discountTypeComboBox_SelectedIndexChanged);
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.categoryComboBox.Enabled = false;
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
            // categoryGroupBox
            // 
            this.categoryGroupBox.Controls.Add(this.categoryComboBox);
            this.categoryGroupBox.Location = new System.Drawing.Point(6, 55);
            this.categoryGroupBox.Name = "categoryGroupBox";
            this.categoryGroupBox.Size = new System.Drawing.Size(136, 46);
            this.categoryGroupBox.TabIndex = 17;
            this.categoryGroupBox.TabStop = false;
            this.categoryGroupBox.Text = "Category of Product";
            // 
            // DiscountControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.discountTypeLabel);
            this.Controls.Add(this.discountValueExplainLabel);
            this.Controls.Add(this.discountValueLabel);
            this.Controls.Add(this.discountValueMaskedTextBox);
            this.Controls.Add(this.discountTypeComboBox);
            this.Controls.Add(this.categoryGroupBox);
            this.Name = "DiscountControl";
            this.Size = new System.Drawing.Size(279, 105);
            this.categoryGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label discountTypeLabel;
        private System.Windows.Forms.Label discountValueExplainLabel;
        private System.Windows.Forms.Label discountValueLabel;
        private System.Windows.Forms.MaskedTextBox discountValueMaskedTextBox;
        private System.Windows.Forms.ComboBox discountTypeComboBox;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.GroupBox categoryGroupBox;
    }
}
