﻿using System;
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
            addButton.Enabled = true;
        }

        private void categoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            addButton.Enabled = true;
        }

        private void basePriceMaskedTextBox_TextChanged(object sender, EventArgs e)
        {
            addButton.Enabled = true;
        }

        private void addButton_Click(object sender, EventArgs e)
        {

        }
    }
}
