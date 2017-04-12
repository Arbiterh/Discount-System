using BusinessLogic;
using System;
using System.Windows.Forms;

namespace View
{
    public partial class MainForm : Form
    {
        private IDiscount _discount;

        public MainForm()
        {
            InitializeComponent();
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
            form.Show(this);
        }

        private void removeFromBasketButton_Click(object sender, EventArgs e)
        {
            try
            {
                productBindingSource.RemoveCurrent();
            }
            catch (InvalidOperationException)
            {
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
 * 3. реализовать нормальную проверку на включение кнопки на форме добавления скидки +
 * обработать там эксепшен на значение процентной скидки
 * 5. (Желательно) запилить кнопки рандома
 */
