using System;
using System.Windows.Forms;
using BusinessLogic;

namespace View
{
    /// <summary>
    /// Форма, оперирующая с прайс-листом
    /// </summary>
    public partial class PriceListForm : Form
    {
        /// <summary>
        /// Свойство, хранящее экземпляр продукта для передачи на главную форму
        /// </summary>
        public object Product { get; private set; }
        /// <summary>
        /// Стандартный конструктор
        /// </summary>
        public PriceListForm()
        {
            InitializeComponent();
#if DEBUG
            randomButton.Visible = true;
#endif
        }

        private void PriceListForm_Load(object sender, EventArgs e)
        {
            Project.Deserialize(ref Project.PriceList, Project.PriceListFilePath);
            priceListBindingSource.DataSource = Project.PriceList;
        }

        private void addFromPriceListToCartButton_Click(object sender, EventArgs e)
        {
            Product = priceListBindingSource.Current;
        }

        private void removeFromPriceButton_Click(object sender, EventArgs e)
        {
            if (priceListBindingSource.Current != null)
                priceListBindingSource.RemoveCurrent();
        }

        private void addToPriceButton_Click(object sender, EventArgs e)
        {
            var form = new ProductForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                priceListBindingSource.Add(form.Product);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            priceSaveFileDialog = new SaveFileDialog();
            if (!(priceSaveFileDialog.FileName == null ||
                  priceSaveFileDialog.ShowDialog() == DialogResult.Cancel))
            {
                Project.Serialize(ref Project.PriceList, priceSaveFileDialog.FileName);
            }
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            priceOpenFileDialog = new OpenFileDialog();
            if (!(priceOpenFileDialog.FileName == null ||
                  priceOpenFileDialog.ShowDialog() == DialogResult.Cancel))
            {
                Project.Deserialize(ref Project.PriceList, priceOpenFileDialog.FileName);
            }
            priceListBindingSource.DataSource = Project.PriceList;
            priceListDataGridView.Update();
        }

        private void randomButton_Click(object sender, EventArgs e)
        {
            var product = new Product
            {
                BasePrice = Math.Round(Project.Rnd.Next(1, 100000) * Project.Rnd.NextDouble(), 2),
                Type = (Category)Project.Rnd.Next(1, 4)
            };
            product.ResultPrice = product.BasePrice;
            var numberOfChars = Project.Rnd.Next(20);
            for (var i = 0; i < numberOfChars; i++)
            {
                var symbolCategory = Project.Rnd.Next(3);
                switch (symbolCategory)
                {
                    case 0:
                        product.Name += Convert.ToChar(Project.Rnd.Next(48, 58)); 
                        break;
                    case 1:
                        product.Name += Convert.ToChar(Project.Rnd.Next(65, 91));
                        break;
                    case 2:
                        product.Name += Convert.ToChar(Project.Rnd.Next(97, 123));
                        break;
                }
            }
            priceListBindingSource.Add(product);
        }
    }
}
