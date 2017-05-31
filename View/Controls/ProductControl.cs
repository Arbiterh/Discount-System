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
            this.SuspendLayout();
            // 
            // ProductControl
            // 
            this.Name = "ProductControl";
            this.Size = new System.Drawing.Size(318, 155);
            this.ResumeLayout(false);

        }
    }
}
