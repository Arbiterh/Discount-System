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
//        private IDiscount _discount;
        private List<Product> _productList;

        public MainForm()
        {
            InitializeComponent();
//            _productList = new List<Product>();
            productBindingSource.DataSource = _productList;
        
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

        private void resultCheckingDiscountNumberLabel_Click(object sender, EventArgs e)
        {

        }
        
      //  private void discountNumberMaskedTextBox_ModifiedChanged(object sender, EventArgs e)
      //  {
      //      var form = new DiscountListForm();
      //      var index = Convert.ToInt32(discountNumberMaskedTextBox.Text);
      //      if (form.iDiscountBindingSource[index] != null)
      //      {
      //          resultCheckingDiscountNumberLabel.Text = @"Ok";
      ////          _discount = form.iDiscountBindingSource[index];
      //      }
      //      else
      //      {
      //          resultCheckingDiscountNumberLabel.Text = @"Wrong code";
      //      }
      //      resultCheckingDiscountNumberLabel.Visible = true;
      //  }

        private void discountNumberMaskedTextBox_ChangeUICues(object sender, UICuesEventArgs e)
        {
            var form = new DiscountListForm();
            var index = Convert.ToInt32(discountNumberMaskedTextBox.Text);
            if (form.iDiscountBindingSource[index] != null)
            {
                resultCheckingDiscountNumberLabel.Text = @"Ok";
                //          _discount = form.iDiscountBindingSource[index];
            }
            else
            {
                resultCheckingDiscountNumberLabel.Text = @"Wrong code";
            }
            resultCheckingDiscountNumberLabel.Visible = true;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cartSaveFileDialog = new SaveFileDialog();
            if (!(cartSaveFileDialog.FileName == null ||
                  cartSaveFileDialog.ShowDialog() == DialogResult.Cancel))
            {
                Project.Serialize(_productList, cartSaveFileDialog.FileName);
            }
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cartOpenFileDialog = new OpenFileDialog();
            if (!(cartOpenFileDialog.FileName == null ||
                  cartOpenFileDialog.ShowDialog() == DialogResult.Cancel))
            {
                Project.Deserialize(_productList, cartOpenFileDialog.FileName);
            }
        }

        private void resultButton_Click(object sender, EventArgs e)
        {
//            foreach ()
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
