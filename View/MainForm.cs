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
        private IDiscount _discount;
//        private List<Product> productList;

        public MainForm()
        {
            InitializeComponent();
            productBindingSource.DataSource = Project.ProductList;
//            _productList = new List<Product>();
#if DEBUG
            showDiscountFormButton.Visible = true;
#endif
        }

        private void addFromProductListButton_Click(object sender, EventArgs e)
        {
            var form = new PriceListForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                productBindingSource.Add(form.Product);
            }
        }

        private void showDiscountFormButton_Click(object sender, EventArgs e)
        {
            var form = new DiscountListForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
            }
        }

        private void removeFromBasketButton_Click(object sender, EventArgs e)
        {
            try
            {
                productBindingSource.RemoveCurrent();
            }
            catch (System.InvalidOperationException)
            {
                return;
            }
        }

        private void clearCartButton_Click(object sender, EventArgs e)
        {
            productBindingSource.Clear();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cartSaveFileDialog = new SaveFileDialog();
            if (!(cartSaveFileDialog.FileName == null ||
                  cartSaveFileDialog.ShowDialog() == DialogResult.Cancel))
            {
                Project.Serialize(ref Project.ProductList, cartSaveFileDialog.FileName);
            }
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cartOpenFileDialog = new OpenFileDialog();
            if (!(cartOpenFileDialog.FileName == null ||
                  cartOpenFileDialog.ShowDialog() == DialogResult.Cancel))
            {
                Project.Deserialize(ref Project.ProductList, cartOpenFileDialog.FileName);
            }
            productBindingSource.DataSource = Project.ProductList;
            cartDataGridView.Update();
        }

        private void resultButton_Click(object sender, EventArgs e)
        {
            Project.ResultPrice = 0;
            foreach (var product in Project.ProductList)
            {
                _discount.DoDiscount(product);
                Project.ResultPrice += product.ResultPrice;
            }
            var form = new ResultPriceForm();
            form.Show(this);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            productBindingSource.DataSource = Project.ProductList;
        }

        private void checkDiscountButton_Click(object sender, EventArgs e)
        {
            try
            {
                var index = Convert.ToInt32(discountNumberMaskedTextBox.Text);
                if (Project.DiscountList[index] != null)
                {
                    resultCheckingDiscountNumberLabel.Text = @"Ok";
                    _discount = Project.DiscountList[index];
                }
                else
                    resultCheckingDiscountNumberLabel.Text = @"Wrong code";
                resultCheckingDiscountNumberLabel.Visible = true;
            }
            catch (ArgumentOutOfRangeException)
            {
                resultCheckingDiscountNumberLabel.Text = @"Wrong code";
                resultCheckingDiscountNumberLabel.Visible = true;
            }
        }
    }
}

/*TO DO LIST:
 * 1. реализовать грамотное отображение типов скидки и их айди на дискаунтлист форме
 * 2. реализовать обращение к скидке с дискаунт листа на форме мейн
 * 3. реализовать нормальную проверку на включение кнопки на форме добавления скидки +
 * обработать там эксепшен на значение процентной скидки
 * 4. реализовать (де)сериализацию (прайс, скидки, и корзина с выбором куда), сохранение т.е.
 * 5. (Желательно) запилить кнопки рандома
 */
