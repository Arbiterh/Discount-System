using System;
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
            Close();
        }

        private void ResultPriceForm_Load(object sender, EventArgs e)
        {
            resultLabel.Text = @"Result: " + Convert.ToString(Project.ResultPrice);
        }
    }
}
