namespace View.Controls
{
    partial class ProductControl
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
            this.basePriceExplainLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.basePriceLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.categoryGroupBox = new System.Windows.Forms.GroupBox();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.basePriceMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.categoryGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // basePriceExplainLabel
            // 
            this.basePriceExplainLabel.AutoSize = true;
            this.basePriceExplainLabel.Location = new System.Drawing.Point(125, 35);
            this.basePriceExplainLabel.Name = "basePriceExplainLabel";
            this.basePriceExplainLabel.Size = new System.Drawing.Size(64, 13);
            this.basePriceExplainLabel.TabIndex = 16;
            this.basePriceExplainLabel.Text = "More than 0";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(66, 6);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(148, 20);
            this.nameTextBox.TabIndex = 15;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // basePriceLabel
            // 
            this.basePriceLabel.AutoSize = true;
            this.basePriceLabel.Location = new System.Drawing.Point(3, 35);
            this.basePriceLabel.Name = "basePriceLabel";
            this.basePriceLabel.Size = new System.Drawing.Size(57, 13);
            this.basePriceLabel.TabIndex = 14;
            this.basePriceLabel.Text = "Base price";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(3, 9);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 13;
            this.nameLabel.Text = "Name";
            // 
            // categoryGroupBox
            // 
            this.categoryGroupBox.Controls.Add(this.categoryComboBox);
            this.categoryGroupBox.Location = new System.Drawing.Point(3, 61);
            this.categoryGroupBox.Name = "categoryGroupBox";
            this.categoryGroupBox.Size = new System.Drawing.Size(116, 44);
            this.categoryGroupBox.TabIndex = 12;
            this.categoryGroupBox.TabStop = false;
            this.categoryGroupBox.Text = "Category of Product";
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.categoryComboBox.Enabled = false;
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
            // basePriceMaskedTextBox
            // 
            this.basePriceMaskedTextBox.Enabled = false;
            this.basePriceMaskedTextBox.Location = new System.Drawing.Point(66, 32);
            this.basePriceMaskedTextBox.Mask = "99990.00";
            this.basePriceMaskedTextBox.Name = "basePriceMaskedTextBox";
            this.basePriceMaskedTextBox.Size = new System.Drawing.Size(53, 20);
            this.basePriceMaskedTextBox.TabIndex = 11;
            this.basePriceMaskedTextBox.Text = "0000000";
            this.basePriceMaskedTextBox.TextChanged += new System.EventHandler(this.basePriceMaskedTextBox_TextChanged);
            // 
            // ProductControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.basePriceExplainLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.basePriceLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.categoryGroupBox);
            this.Controls.Add(this.basePriceMaskedTextBox);
            this.Name = "ProductControl";
            this.Size = new System.Drawing.Size(218, 109);
            this.categoryGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label basePriceExplainLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label basePriceLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.GroupBox categoryGroupBox;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.MaskedTextBox basePriceMaskedTextBox;
    }
}
