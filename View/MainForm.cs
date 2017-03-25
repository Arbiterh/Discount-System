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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var discountList = new List<IDiscount>();
            iDiscountBindingSource.DataSource = discountList;
            var productList = new List<Product>();
            productBindingSource.DataSource = productList;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AddDiscountButton_Click(object sender, EventArgs e)
        {
            var form = new DiscountForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                
            }
        }

        private void RemoveDiscountButton_Click(object sender, EventArgs e)
        {

        }
    }
}
