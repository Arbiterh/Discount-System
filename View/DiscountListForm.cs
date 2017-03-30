using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;

namespace View
{
    public partial class DiscountListForm : Form
    {
        private List<IDiscount> list;
        public DiscountListForm()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var form = new DiscountForm();
            if (form.ShowDialog() != DialogResult.OK) return;
            iDiscountBindingSource.Add(form.Discount);
            var index = iDiscountBindingSource.Count;
            WriteDiscountInfo(form.Discount, index - 1);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        //дописать ремув, так как сейчас при ремуве выведенные значения индексов и типов
        //скидок остаются старые. Либо придумать иной механизм (например занос типов и
        //индексов в биндингсоурс 
        private void removeButton_Click(object sender, EventArgs e)
        {
            try
            {
                //var index = iDiscountBindingSource.IndexOf(iDiscountBindingSource.Current);
                iDiscountBindingSource.RemoveCurrent();
                //for (var i = index; i < iDiscountBindingSource.Count; i++)
                //{
                //    WriteDiscountInfo(iDiscountBindingSource.List, i);
                //}
            }
            catch (System.InvalidOperationException)
            {
                return;
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            iDiscountBindingSource.Clear();
        }

        private void modifyButton_Click(object sender, EventArgs e)
        {
            if (iDiscountBindingSource.Current == null) return;
            var form = new DiscountForm
                {Discount = iDiscountBindingSource.Current as IDiscount};
            if (form.ShowDialog() != DialogResult.OK) return;
            var index = iDiscountBindingSource.IndexOf(iDiscountBindingSource.Current);
            iDiscountBindingSource.Insert(index, form.Discount);
            iDiscountBindingSource.RemoveAt(index + 1);
            WriteDiscountInfo(form.Discount, index);
        }

        private void WriteDiscountInfo(IDiscount discount, int index)
        {
            discountListDataGridView[0, index].Value = index;
            if (discount is PercentDiscount)
            {
                discountListDataGridView[1, index].Value = @"Percent";
            }
            else if (discount is SertificateDiscount)
            {
                discountListDataGridView[1, index].Value = @"Sertificate";
            }
        }

        private void discountListDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DiscountListForm_Load(object sender, EventArgs e)
        {
            Project.Deserialize(list, @"C:\Users\andre\Desktop\discsys.dss");
        }
    }
}
