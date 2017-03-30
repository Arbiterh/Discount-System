using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;

namespace View
{
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            
        }

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
                if (foodRadioButton.Checked == true)
                    product.Type = Category.Food;
                if (alcoholRadioButton.Checked == true)
                    product.Type = Category.Alcohol;
                if (chemistryRadioButton.Checked == true)
                    product.Type = Category.Chemistry;
                return product;
            }
        }

        private void foodRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            addButton.Enabled = true;
        }

        private void basePriceMaskedTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void alcoholRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            addButton.Enabled = true;
        }

        private void chemistryRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            addButton.Enabled = true;
        }
    }
}
