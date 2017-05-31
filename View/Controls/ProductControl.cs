using System;
using System.Windows.Forms;
using BusinessLogic;

namespace View.Controls
{
    /// <summary>
    /// Контрол, содержащий на себе элементы для добавления экземпляра продукта
    /// </summary>
    public partial class ProductControl : UserControl
    {
        private Label basePriceExplainLabel;
        private TextBox nameTextBox;
        private Label basePriceLabel;
        private Label nameLabel;
        private GroupBox categoryGroupBox;
        private ComboBox categoryComboBox;
        private MaskedTextBox basePriceMaskedTextBox;

        /// <summary>
        /// Стандартный конструктор
        /// </summary>
        public ProductControl()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Свойство, хранящее экземпляр продукта
        /// </summary>
        public Product Product
        {
            get
            {
                var product = new Product
                {
                    Name = nameTextBox.Text,
                    BasePrice = Convert.ToDouble(basePriceMaskedTextBox.Text)
                };
                product.ResultPrice = product.BasePrice;
                switch (categoryComboBox.SelectedIndex)
                {
                    case 0:
                        product.Type = Category.Food;
                        break;
                    case 1:
                        product.Type = Category.Alcohol;
                        break;
                    case 2:
                        product.Type = Category.Chemistry;
                        break;
                }
                return product;
            }
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (nameTextBox.Text != null && nameTextBox.Text != @"")
                basePriceMaskedTextBox.Enabled = true;
            else
            {
                basePriceMaskedTextBox.Enabled = false;
                categoryComboBox.Enabled = false;
                Project.AddButtonEnabledProductForm = false;
            }
        }

        private void categoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (categoryComboBox.SelectedIndex != -1)
                Project.AddButtonEnabledProductForm = true;
        }

        private void basePriceMaskedTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDouble(basePriceMaskedTextBox.Text) != 0)
                    categoryComboBox.Enabled = true;
                else
                {
                    categoryComboBox.Enabled = false;
                    Project.AddButtonEnabledProductForm = false;
                }
            }
            catch (FormatException)
            {
                categoryComboBox.Enabled = false;
                Project.AddButtonEnabledProductForm = false;
            }
        }

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
            this.basePriceExplainLabel.Location = new System.Drawing.Point(125, 37);
            this.basePriceExplainLabel.Name = "basePriceExplainLabel";
            this.basePriceExplainLabel.Size = new System.Drawing.Size(64, 13);
            this.basePriceExplainLabel.TabIndex = 22;
            this.basePriceExplainLabel.Text = "More than 0";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(66, 8);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(148, 20);
            this.nameTextBox.TabIndex = 21;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // basePriceLabel
            // 
            this.basePriceLabel.AutoSize = true;
            this.basePriceLabel.Location = new System.Drawing.Point(3, 37);
            this.basePriceLabel.Name = "basePriceLabel";
            this.basePriceLabel.Size = new System.Drawing.Size(57, 13);
            this.basePriceLabel.TabIndex = 20;
            this.basePriceLabel.Text = "Base price";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(3, 11);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 19;
            this.nameLabel.Text = "Name";
            // 
            // categoryGroupBox
            // 
            this.categoryGroupBox.Controls.Add(this.categoryComboBox);
            this.categoryGroupBox.Location = new System.Drawing.Point(3, 63);
            this.categoryGroupBox.Name = "categoryGroupBox";
            this.categoryGroupBox.Size = new System.Drawing.Size(116, 44);
            this.categoryGroupBox.TabIndex = 18;
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
            this.basePriceMaskedTextBox.Location = new System.Drawing.Point(66, 34);
            this.basePriceMaskedTextBox.Mask = "99990.00";
            this.basePriceMaskedTextBox.Name = "basePriceMaskedTextBox";
            this.basePriceMaskedTextBox.Size = new System.Drawing.Size(53, 20);
            this.basePriceMaskedTextBox.TabIndex = 17;
            this.basePriceMaskedTextBox.Text = "0000000";
            this.basePriceMaskedTextBox.TextChanged += new System.EventHandler(this.basePriceMaskedTextBox_TextChanged);
            // 
            // ProductControl
            // 
            this.Controls.Add(this.basePriceExplainLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.basePriceLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.categoryGroupBox);
            this.Controls.Add(this.basePriceMaskedTextBox);
            this.Name = "ProductControl";
            this.Size = new System.Drawing.Size(223, 110);
            this.categoryGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
