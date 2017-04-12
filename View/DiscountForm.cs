using BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    //допилить чек результата, сейчас кнопка включается только при выборе радиобаттона,
    //логика неверна
    public partial class DiscountForm : Form
    {
        public DiscountForm()
        {
            InitializeComponent();
        }

        public DiscountForm(IDiscount discount)
        {
            InitializeComponent();
        }

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
                        var sertificateDiscount = new SertificateDiscount
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
                else if (value is SertificateDiscount)
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
            }
        }

        private void discountTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (discountTypeComboBox.SelectedIndex == 0)
            {
                discountValueMaskedTextBox.Mask = @"009";
                discountValueExplainLabel.Text = @"Input int number from 0 to 100";
            }
            if (discountTypeComboBox.SelectedIndex == 1)
            {
                discountValueMaskedTextBox.Mask = @"00009";
                discountValueExplainLabel.Text = @"Input int number from 0 to 99999";
            }
            discountValueExplainLabel.Visible = true;
//            if (DiscountIsCorrect())
                okButton.Enabled = true;
        }

        private bool DiscountIsCorrect()
        {
            switch (discountTypeComboBox.SelectedIndex)
            {
                case -1:
                    return false;
                case 0:
                    if (Convert.ToInt32(discountValueMaskedTextBox.Text) < 0 || 
                        Convert.ToInt32(discountValueMaskedTextBox.Text) > 100) return false;
                    break;
                case 1:
                    if (Convert.ToInt32(discountValueMaskedTextBox.Text) < 0) return false;
                    break;
            }
            return categoryComboBox.SelectedIndex != -1;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
        }

        private void categoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
//            if (DiscountIsCorrect())
                okButton.Enabled = true;
        }

        private void discountValueMaskedTextBox_TextChanged(object sender, EventArgs e)
        {
//            if (DiscountIsCorrect())
                okButton.Enabled = true;
        }
    }
}
