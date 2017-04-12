﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class ResultPriceForm : Form
    {
        public ResultPriceForm()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ResultPriceForm_Load(object sender, EventArgs e)
        {
            resultLabel.Text = @"Result: " + Convert.ToString(Project.ResultPrice);
        }
    }
}
