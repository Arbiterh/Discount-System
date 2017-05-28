using BusinessLogic;
using System;
using System.Windows.Forms;
using View.Controls;

namespace View
{
    public partial class DiscountForm : Form
    {
        private readonly DiscountControl _discountControl;

        public DiscountForm()
        {
            InitializeComponent();
           _discountControl = new DiscountControl();
            Controls.Add(_discountControl);
        }

        public IDiscount Discount
        {
            get { return _discountControl.Discount; }
            set { _discountControl.Discount = value; }
        }

        private void timerEnabledOk_Tick(object sender, EventArgs e)
        {
            okButton.Enabled = Project.OkButtonEnabledDiscountForm;
        }
        
    }
}
