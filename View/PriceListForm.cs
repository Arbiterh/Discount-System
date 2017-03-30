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
    public partial class PriceListForm : Form
    {
        public object Product { get; private set; }

        public PriceListForm()
        {
            InitializeComponent();
            var priceList = new List<Product>();
            priceListBindingSource.DataSource = priceList;

//            Serialization.Deserialize(priceList, "priceList.dss");
            //var reader = new System.Xml.Serialization.XmlSerializer(typeof(List<Product>));
            //var priceListFile = new System.IO.StreamReader("priceList.dss");
            //priceList = (List<Product>) reader.Deserialize(priceListFile);

#if DEBUG
            addToPriceButton.Visible = true;
            removeFromPriceButton.Visible = true;
#endif
        }

        private void PriceListForm_Load(object sender, EventArgs e)
        {
            Project.Deserialize(priceList, "priceList.dss");
        }

        private void addFromPriceListToCartButton_Click(object sender, EventArgs e)
        {
            Product = priceListBindingSource.Current;
//            MainForm.productBindingSource.Add(priceListBindingSource.Current);
        }

        private void removeFromPriceButton_Click(object sender, EventArgs e)
        {
            try
            {
                priceListBindingSource.RemoveCurrent();
            }
            catch (System.InvalidOperationException)
            {
                return;
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
    }
}
