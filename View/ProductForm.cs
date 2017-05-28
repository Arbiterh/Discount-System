using System;
using System.Windows.Forms;
using BusinessLogic;
using View.Controls;

namespace View
{
    public partial class ProductForm : Form
    {
        private readonly ProductControl _productControl;

        public ProductForm()
        {
            InitializeComponent();
            _productControl = new ProductControl();
            Controls.Add(_productControl);
        }
        
        public Product Product => _productControl.Product;

        private void timerEnabledAdd_Tick(object sender, EventArgs e)
        {
            addButton.Enabled = Project.AddButtonEnabledProductForm;
        }
    }
}
