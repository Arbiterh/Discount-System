using System;
using System.Windows.Forms;

namespace View
{
    /// <summary>
    /// Форма для отображения итоговой цены всех товаров в корзине с учётом скидки
    /// </summary>
    public partial class ResultPriceForm : Form
    {
        /// <summary>
        /// Стандартный конструктор
        /// </summary>
        public ResultPriceForm()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ResultPriceForm_Load(object sender, EventArgs e)
        {
            resultLabel.Text = @"Result: " + Convert.ToString(Project.ResultPrice);
        }
    }
}
