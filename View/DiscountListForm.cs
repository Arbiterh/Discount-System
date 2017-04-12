using System;
using System.Windows.Forms;
using BusinessLogic;

namespace View
{
    public partial class DiscountListForm : Form
    {
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
            Project.Serialize(ref Project.DiscountList, Project.DiscountListFilePath);
            Close();
        }

        //дописать ремув, так как сейчас при ремуве выведенные значения индексов и типов
        //скидок остаются старые. Либо придумать иной механизм (например занос типов и
        //индексов в биндингсоурс 
        private void removeButton_Click(object sender, EventArgs e)
        {
            try
            {
                iDiscountBindingSource.RemoveCurrent();
                var i = 0;
                foreach (var discount in Project.DiscountList)
                {
                    WriteDiscountInfo(discount, i);
                    i++;
                }
            }
            catch (InvalidOperationException)
            {
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

        private void DiscountListForm_Load(object sender, EventArgs e)
        {
            Project.Deserialize(ref Project.DiscountList, Project.DiscountListFilePath);
            iDiscountBindingSource.DataSource = Project.DiscountList;
        }
    }
}
