﻿using BusinessLogic;
using System;
using System.Windows.Forms;
using View.Controls;

namespace View
{
    /// <summary>
    /// Форма для редактирования экземпляра скидки
    /// </summary>
    public partial class DiscountForm : Form
    {
        private readonly DiscountControl _discountControl;
        /// <summary>
        /// Стандартный конструктор, инициирующий контрол
        /// </summary>
        public DiscountForm()
        {
            InitializeComponent();
           _discountControl = new DiscountControl();
            Controls.Add(_discountControl);
        }
        /// <summary>
        /// Свойство скидки, оперирующее с таковым на контроле
        /// </summary>
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
