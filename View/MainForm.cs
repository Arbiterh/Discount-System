using System;
using System.Windows.Forms;

namespace View
{
    public partial class MainForm : Form
    {

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
            if (productBindingSource.Current != null)
                productBindingSource.RemoveCurrent();
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
            if (Project.Discount != null)
            {
                foreach (var product in Project.ProductList)
                {
                    Project.Discount.DoDiscount(product);
                    Project.ResultPrice += product.ResultPrice;
                }
            }
            else
                foreach (var product in Project.ProductList)
                {
                    Project.ResultPrice += product.ResultPrice;
                }
            var form = new ResultPriceForm();
            form.Show(this);
            productBindingSource.ResetBindings(false);
//            NullReferenceException
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            productBindingSource.DataSource = Project.ProductList;
        }

        private void checkDiscountButton_Click(object sender, EventArgs e)
        {
            Project.Deserialize(ref Project.DiscountList, Project.DiscountListFilePath);
            try
            {
                var index = Convert.ToInt32(discountNumberMaskedTextBox.Text);
                if (Project.DiscountList[index] != null)
                {
                    resultCheckingDiscountNumberLabel.Text = @"Ok";
                    Project.Discount = Project.DiscountList[index];
                }
                else
                {
                    Project.Discount = null;
                    resultCheckingDiscountNumberLabel.Text = @"Wrong code";
                }
            resultCheckingDiscountNumberLabel.Visible = true;
            }
            catch (ArgumentOutOfRangeException)
            {
                Project.Discount = null;
                resultCheckingDiscountNumberLabel.Text = @"Wrong code";
                resultCheckingDiscountNumberLabel.Visible = true;
            }
            catch (FormatException)
            {
                Project.Discount = null;
                resultCheckingDiscountNumberLabel.Text = @"Wrong code";
                resultCheckingDiscountNumberLabel.Visible = true;
            }
        }
    }
}
