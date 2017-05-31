using System;
using BusinessLogic;
using System.Windows.Forms;

namespace View.Controls
{
    /// <summary>
    /// Контрол, содержащий на себе элементы для редактирования экземпляра скидки
    /// </summary>
    public partial class DiscountControl : UserControl
    {
        /// <summary>
        /// Стандартный конструктор
        /// </summary>
        public DiscountControl()
        {
            InitializeComponent();
        }

        private Label discountTypeLabel;
        private Label discountValueExplainLabel;
        private Label discountValueLabel;
        private MaskedTextBox discountValueMaskedTextBox;
        private ComboBox discountTypeComboBox;
        private GroupBox categoryGroupBox;
        private ComboBox categoryComboBox;
        private bool _readOnly;
        /// <summary>
        /// Свойство, хранящее экземпляр скидки
        /// </summary>
        public IDiscount Discount
        {
            get
            {
                switch (discountTypeComboBox.SelectedIndex)
                {
                    case 0:
                        var percentDiscount = new PercentDiscount
                        {
                            DiscountValue = Convert.ToInt32(discountValueMaskedTextBox.Text)
                        };
                        switch (categoryComboBox.SelectedIndex)
                        {
                            case 0:
                                percentDiscount.CategoryOfProduct = Category.All;
                                break;
                            case 1:
                                percentDiscount.CategoryOfProduct = Category.Food;
                                break;
                            case 2:
                                percentDiscount.CategoryOfProduct = Category.Alcohol;
                                break;
                            case 3:
                                percentDiscount.CategoryOfProduct = Category.Chemistry;
                                break;
                        }
                        return percentDiscount;
                    case 1:
                        var sertificateDiscount = new CertificateDiscount
                        {
                            DiscountValue = Convert.ToInt32(discountValueMaskedTextBox.Text)
                        };
                        switch (categoryComboBox.SelectedIndex)
                        {
                            case 0:
                                sertificateDiscount.CategoryOfProduct = Category.All;
                                break;
                            case 1:
                                sertificateDiscount.CategoryOfProduct = Category.Food;
                                break;
                            case 2:
                                sertificateDiscount.CategoryOfProduct = Category.Alcohol;
                                break;
                            case 3:
                                sertificateDiscount.CategoryOfProduct = Category.Chemistry;
                                break;
                        }
                        return sertificateDiscount;
                }
                return null;
            }
            set
            {
                if (value is PercentDiscount)
                {
                    discountTypeComboBox.SelectedIndex = 0;
                }
                else if (value is CertificateDiscount)
                {
                    discountTypeComboBox.SelectedIndex = 1;
                }
                discountValueMaskedTextBox.Text = Convert.ToString(value.DiscountValue);
                switch (value.CategoryOfProduct)
                {
                    case Category.All:
                        categoryComboBox.SelectedIndex = 0;
                        break;
                    case Category.Food:
                        categoryComboBox.SelectedIndex = 1;
                        break;
                    case Category.Alcohol:
                        categoryComboBox.SelectedIndex = 2;
                        break;
                    case Category.Chemistry:
                        categoryComboBox.SelectedIndex = 3;
                        break;
                }
                //add exceptions
            }
        }
        /// <summary>
        /// Свойство, определяющее тип доступа к контролу
        /// </summary>
        public bool ReadOnly
        {
            get { return _readOnly; }
            set
            {
                discountTypeComboBox.Enabled = !value;
                discountValueMaskedTextBox.Enabled = !value;
                categoryComboBox.Enabled = !value;
                _readOnly = value;
            }
        }

        private void discountTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            discountValueMaskedTextBox.Enabled = false;
            if (discountTypeComboBox.SelectedIndex == 0)
            {
                discountValueMaskedTextBox.Mask = @"009";
                discountValueExplainLabel.Text = @"Input int number from 0 to 100";
                discountValueMaskedTextBox.Enabled = true;
            }
            if (discountTypeComboBox.SelectedIndex == 1)
            {
                discountValueMaskedTextBox.Mask = @"00009";
                discountValueExplainLabel.Text = @"Input int number from 0 to 99999";
                discountValueMaskedTextBox.Enabled = true;
            }
            discountValueExplainLabel.Visible = true;
        }

        private void categoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (categoryComboBox.SelectedIndex != -1)
                Project.OkButtonEnabledDiscountForm = true;
        }

        private void discountValueMaskedTextBox_TextChanged(object sender, EventArgs e)
        {
            categoryComboBox.Enabled = false;
            try
            {
                if (Discount is PercentDiscount)
                    if (Convert.ToInt32(discountValueMaskedTextBox.Text) <= 100)
                        categoryComboBox.Enabled = true;
                if (Discount is CertificateDiscount)
                    categoryComboBox.Enabled = true;
            }
            catch (FormatException)
            {
                categoryComboBox.Enabled = false;
            }
            catch (ArgumentOutOfRangeException)
            {
                categoryComboBox.Enabled = false;
            }
        }

        private void InitializeComponent()
        {
            this.discountTypeLabel = new System.Windows.Forms.Label();
            this.discountValueExplainLabel = new System.Windows.Forms.Label();
            this.discountValueLabel = new System.Windows.Forms.Label();
            this.discountValueMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.discountTypeComboBox = new System.Windows.Forms.ComboBox();
            this.categoryGroupBox = new System.Windows.Forms.GroupBox();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.categoryGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // discountTypeLabel
            // 
            this.discountTypeLabel.AutoSize = true;
            this.discountTypeLabel.Location = new System.Drawing.Point(3, 9);
            this.discountTypeLabel.Name = "discountTypeLabel";
            this.discountTypeLabel.Size = new System.Drawing.Size(72, 13);
            this.discountTypeLabel.TabIndex = 27;
            this.discountTypeLabel.Text = "Discount type";
            // 
            // discountValueExplainLabel
            // 
            this.discountValueExplainLabel.AutoSize = true;
            this.discountValueExplainLabel.Location = new System.Drawing.Point(128, 36);
            this.discountValueExplainLabel.Name = "discountValueExplainLabel";
            this.discountValueExplainLabel.Size = new System.Drawing.Size(148, 13);
            this.discountValueExplainLabel.TabIndex = 26;
            this.discountValueExplainLabel.Text = "Input int number from 0 to 100";
            this.discountValueExplainLabel.Visible = false;
            // 
            // discountValueLabel
            // 
            this.discountValueLabel.AutoSize = true;
            this.discountValueLabel.Location = new System.Drawing.Point(3, 36);
            this.discountValueLabel.Name = "discountValueLabel";
            this.discountValueLabel.Size = new System.Drawing.Size(78, 13);
            this.discountValueLabel.TabIndex = 25;
            this.discountValueLabel.Text = "Discount value";
            // 
            // discountValueMaskedTextBox
            // 
            this.discountValueMaskedTextBox.Enabled = false;
            this.discountValueMaskedTextBox.Location = new System.Drawing.Point(81, 33);
            this.discountValueMaskedTextBox.Mask = "009";
            this.discountValueMaskedTextBox.Name = "discountValueMaskedTextBox";
            this.discountValueMaskedTextBox.Size = new System.Drawing.Size(41, 20);
            this.discountValueMaskedTextBox.TabIndex = 24;
            this.discountValueMaskedTextBox.TextChanged += new System.EventHandler(this.discountValueMaskedTextBox_TextChanged);
            // 
            // discountTypeComboBox
            // 
            this.discountTypeComboBox.FormattingEnabled = true;
            this.discountTypeComboBox.Items.AddRange(new object[] {
            "Percent discount",
            "Sertificate discount"});
            this.discountTypeComboBox.Location = new System.Drawing.Point(81, 6);
            this.discountTypeComboBox.Name = "discountTypeComboBox";
            this.discountTypeComboBox.Size = new System.Drawing.Size(116, 21);
            this.discountTypeComboBox.TabIndex = 22;
            this.discountTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.discountTypeComboBox_SelectedIndexChanged);
            // 
            // categoryGroupBox
            // 
            this.categoryGroupBox.Controls.Add(this.categoryComboBox);
            this.categoryGroupBox.Location = new System.Drawing.Point(6, 59);
            this.categoryGroupBox.Name = "categoryGroupBox";
            this.categoryGroupBox.Size = new System.Drawing.Size(136, 46);
            this.categoryGroupBox.TabIndex = 23;
            this.categoryGroupBox.TabStop = false;
            this.categoryGroupBox.Text = "Category of Product";
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.categoryComboBox.Enabled = false;
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Items.AddRange(new object[] {
            "All",
            "Food",
            "Alcohol",
            "Chemistry"});
            this.categoryComboBox.Location = new System.Drawing.Point(3, 16);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(130, 21);
            this.categoryComboBox.TabIndex = 0;
            this.categoryComboBox.SelectedIndexChanged += new System.EventHandler(this.categoryComboBox_SelectedIndexChanged);
            // 
            // DiscountControl
            // 
            this.Controls.Add(this.discountTypeLabel);
            this.Controls.Add(this.discountValueExplainLabel);
            this.Controls.Add(this.discountValueLabel);
            this.Controls.Add(this.discountValueMaskedTextBox);
            this.Controls.Add(this.discountTypeComboBox);
            this.Controls.Add(this.categoryGroupBox);
            this.Name = "DiscountControl";
            this.Size = new System.Drawing.Size(275, 110);
            this.categoryGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
