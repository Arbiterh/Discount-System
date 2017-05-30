using System;
using System.Windows.Forms;
using BusinessLogic;

namespace View
{
    /// <summary>
    /// Форма для работы с листом скидок
    /// </summary>
    public partial class DiscountListForm : Form
    {
        /// <summary>
        /// Стандартный конструктор
        /// </summary>
        public DiscountListForm()
        {
            InitializeComponent();
#if DEBUG
                randomButton.Visible = true;
#endif
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

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (iDiscountBindingSource.Current == null) return;
            iDiscountBindingSource.RemoveCurrent();
            var i = 0;
            foreach (var discount in Project.DiscountList)
            {
                WriteDiscountInfo(discount, i);
                i++;
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
            { Discount = iDiscountBindingSource.Current as IDiscount };
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
            else if (discount is CertificateDiscount)
            {
                discountListDataGridView[1, index].Value = @"Sertificate";
            }
        }

        private void DiscountListForm_Load(object sender, EventArgs e)
        {
            Project.Deserialize(ref Project.DiscountList, Project.DiscountListFilePath);
            iDiscountBindingSource.DataSource = Project.DiscountList;
            var i = 0;
            foreach (var discount in Project.DiscountList)
            {
                WriteDiscountInfo(discount, i);
                i++;
            }
            discountListDataGridView.Update();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            discountListSaveFileDialog = new SaveFileDialog();
            if (!(discountListSaveFileDialog.FileName == null ||
                  discountListSaveFileDialog.ShowDialog() == DialogResult.Cancel))
            {
                Project.Serialize(ref Project.DiscountList, discountListSaveFileDialog.FileName);
            }
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            discountListOpenFileDialog = new OpenFileDialog();
            if (!(discountListOpenFileDialog.FileName == null ||
                  discountListOpenFileDialog.ShowDialog() == DialogResult.Cancel))
            {
                Project.Deserialize(ref Project.DiscountList, discountListOpenFileDialog.FileName);
            }
            iDiscountBindingSource.DataSource = Project.DiscountList;
            var i = 0;
            foreach (var discount in Project.DiscountList)
            {
                WriteDiscountInfo(discount, i);
                i++;
            }
            discountListDataGridView.Update();
        }

        private void randomButton_Click(object sender, EventArgs e)
        {
            switch (Project.Rnd.Next(2))
            {
                case 0:
                    var percentDiscount = new PercentDiscount()
                        {CategoryOfProduct = (Category) Project.Rnd.Next(4), DiscountValue = Project.Rnd.Next(101)};
                    iDiscountBindingSource.Add(percentDiscount);
                    WriteDiscountInfo(percentDiscount, iDiscountBindingSource.Count - 1);
                    break;
                case 1:
                    var certificateDiscount = new CertificateDiscount()
                        {CategoryOfProduct = (Category)Project.Rnd.Next(4), DiscountValue = Project.Rnd.Next(100000)};
                    iDiscountBindingSource.Add(certificateDiscount);
                    WriteDiscountInfo(certificateDiscount, iDiscountBindingSource.Count - 1);
                    break;
            }
            discountListDataGridView.Update();
        }
    }
}
