using System;
using BusinessLogic;
using System.Windows.Forms;

namespace View.Controls
{
    /// <summary>
    /// Контрол, содержащий на себе элементы для редактирования экземпляра скидки
    /// </summary>
    public partial class DiscountControl : UserControl
    {
        /// <summary>
        /// Стандартный конструктор
        /// </summary>
        public DiscountControl()
        {
            InitializeComponent();
        }

        private bool _readOnly;
        /// <summary>
        /// Свойство, хранящее экземпляр скидки
        /// </summary>
        public IDiscount Discount
        {
            get
            {
                switch (discountTypeComboBox.SelectedIndex)
                {
                    case 0:
                        var percentDiscount = new PercentDiscount
                        {
                            DiscountValue = Convert.ToInt32(discountValueMaskedTextBox.Text)
                        };
                        switch (categoryComboBox.SelectedIndex)
                        {
                            case 0:
                                percentDiscount.CategoryOfProduct = Category.All;
                                break;
                            case 1:
                                percentDiscount.CategoryOfProduct = Category.Food;
                                break;
                            case 2:
                                percentDiscount.CategoryOfProduct = Category.Alcohol;
                                break;
                            case 3:
                                percentDiscount.CategoryOfProduct = Category.Chemistry;
                                break;
                        }
                        return percentDiscount;
                    case 1:
                        var sertificateDiscount = new CertificateDiscount
                        {
                            DiscountValue = Convert.ToInt32(discountValueMaskedTextBox.Text)
                        };
                        switch (categoryComboBox.SelectedIndex)
                        {
                            case 0:
                                sertificateDiscount.CategoryOfProduct = Category.All;
                                break;
                            case 1:
                                sertificateDiscount.CategoryOfProduct = Category.Food;
                                break;
                            case 2:
                                sertificateDiscount.CategoryOfProduct = Category.Alcohol;
                                break;
                            case 3:
                                sertificateDiscount.CategoryOfProduct = Category.Chemistry;
                                break;
                        }
                        return sertificateDiscount;
                }
                return null;
            }
            set
            {
                if (value is PercentDiscount)
                {
                    discountTypeComboBox.SelectedIndex = 0;
                }
                else if (value is CertificateDiscount)
                {
                    discountTypeComboBox.SelectedIndex = 1;
                }
                discountValueMaskedTextBox.Text = Convert.ToString(value.DiscountValue);
                switch (value.CategoryOfProduct)
                {
                    case Category.All:
                        categoryComboBox.SelectedIndex = 0;
                        break;
                    case Category.Food:
                        categoryComboBox.SelectedIndex = 1;
                        break;
                    case Category.Alcohol:
                        categoryComboBox.SelectedIndex = 2;
                        break;
                    case Category.Chemistry:
                        categoryComboBox.SelectedIndex = 3;
                        break;
                }
                //add exceptions
            }
        }
        /// <summary>
        /// Свойство, определяющее тип доступа к контролу
        /// </summary>
        public bool ReadOnly
        {
            get { return _readOnly; }
            set
            {
                discountTypeComboBox.Enabled = !value;
                discountValueMaskedTextBox.Enabled = !value;
                categoryComboBox.Enabled = !value;
                _readOnly = value;
            }
        }

        private void discountTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            discountValueMaskedTextBox.Enabled = false;
            if (discountTypeComboBox.SelectedIndex == 0)
            {
                discountValueMaskedTextBox.Mask = @"009";
                discountValueExplainLabel.Text = @"Input int number from 0 to 100";
                discountValueMaskedTextBox.Enabled = true;
            }
            if (discountTypeComboBox.SelectedIndex == 1)
            {
                discountValueMaskedTextBox.Mask = @"00009";
                discountValueExplainLabel.Text = @"Input int number from 0 to 99999";
                discountValueMaskedTextBox.Enabled = true;
            }
            discountValueExplainLabel.Visible = true;
        }

        private void categoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (categoryComboBox.SelectedIndex != -1)
                Project.OkButtonEnabledDiscountForm = true;
        }
        
        private void discountValueMaskedTextBox_TextChanged(object sender, EventArgs e)
        {
            categoryComboBox.Enabled = false;
            try
            {
                if (Discount is PercentDiscount)
                    if (Convert.ToInt32(discountValueMaskedTextBox.Text) <= 100)
                        categoryComboBox.Enabled = true;
                if (Discount is CertificateDiscount)
                    categoryComboBox.Enabled = true;
            }
            catch (FormatException)
            {
                categoryComboBox.Enabled = false;
            }
            catch (ArgumentOutOfRangeException)
            {
                categoryComboBox.Enabled = false;
            }
        }
    }
}
