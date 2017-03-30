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
                        if (allRadioButton.Checked == true)
                            percentDiscount.CategoryOfProduct = Category.All;
                        else if (foodRadioButton.Checked == true)
                            percentDiscount.CategoryOfProduct = Category.Food;
                        else if (alcoholRadioButton.Checked == true)
                            percentDiscount.CategoryOfProduct = Category.Alcohol;
                        else if (chemistryRadioButton.Checked == true)
                            percentDiscount.CategoryOfProduct = Category.Chemistry;
                        return percentDiscount;
                    case 1:
                        var sertificateDiscount = new SertificateDiscount
                        {
                            DiscountValue = Convert.ToInt32(discountValueMaskedTextBox.Text)
                        };
                        if (allRadioButton.Checked == true)
                            sertificateDiscount.CategoryOfProduct = Category.All;
                        else if (foodRadioButton.Checked == true)
                            sertificateDiscount.CategoryOfProduct = Category.Food;
                        else if (alcoholRadioButton.Checked == true)
                            sertificateDiscount.CategoryOfProduct = Category.Alcohol;
                        else if (chemistryRadioButton.Checked == true)
                            sertificateDiscount.CategoryOfProduct = Category.Chemistry;
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
                        allRadioButton.Checked = true;
                        break;
                    case Category.Food:
                        foodRadioButton.Checked = true;
                        break;
                    case Category.Alcohol:
                        alcoholRadioButton.Checked = true;
                        break;
                    case Category.Chemistry:
                        chemistryRadioButton.Checked = true;
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
        }

        private void OkButton_Click(object sender, EventArgs e)
        {

        }

        private void foodRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            okButton.Enabled = true;
        }

        private void alcoholRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            okButton.Enabled = true;
        }

        private void chemistryRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            okButton.Enabled = true;
        }

        private void allRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            okButton.Enabled = true;
        }
    }
}
