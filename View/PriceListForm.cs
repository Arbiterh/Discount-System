using System;
using System.Windows.Forms;

namespace View
{
    public partial class PriceListForm : Form
    {
        public object Product { get; private set; }

        public PriceListForm()
        {
            InitializeComponent();
#if DEBUG
            addToPriceButton.Visible = true;
            removeFromPriceButton.Visible = true;
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
            try
            {
                priceListBindingSource.RemoveCurrent();
            }
            catch (InvalidOperationException)
            {
            }
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
    }
}
