using System;
using System.Windows.Forms;
using BusinessLogic;
using View.Controls;

namespace View
{
    /// <summary>
    /// Форма для взаимодействия с экземпляром продукта
    /// </summary>
    public partial class ProductForm : Form
    {
        private readonly ProductControl _productControl;
        /// <summary>
        /// Стандартный констуктор, инициирующий контрол
        /// </summary>
        public ProductForm()
        {
            InitializeComponent();
            _productControl = new ProductControl();
            Controls.Add(_productControl);
        }
        /// <summary>
        /// Свойство, получающее продукт из свойства контрола
        /// </summary>
        public Product Product => _productControl.Product;

        private void timerEnabledAdd_Tick(object sender, EventArgs e)
        {
            addButton.Enabled = Project.AddButtonEnabledProductForm;
        }
    }
}
