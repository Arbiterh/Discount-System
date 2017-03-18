using System;

namespace BusinessLogic
{
    /// <summary>
    /// Класс товара
    /// </summary>
    public class Product
    {
        /// <summary>
        /// Поле имени товара, по умолчанию Empty
        /// </summary>
        private string _name = string.Empty;
        /// <summary>
        /// Поле цены без учета скидки, по умолчанию 0
        /// </summary>
        private double _basePrice = 0;
        /// <summary>
        /// Поле цены, с учетом скидки, по умолчанию 0
        /// </summary>
        private double _resultPrice = 0;
        /// <summary>
        /// Поле категории товара
        /// </summary>
        private Category _type;
        /// <summary>
        /// Свойство имени товара
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Свойство цены, без учета скидки
        /// </summary>
        public double BasePrice
        {
            get { return _basePrice; }
            set
            {
                if (value > 0)
                    _basePrice = value;
                else
                    throw new ArgumentOutOfRangeException();
            }
        }

        /// <summary>
        /// Свойство цены с учетом скидки
        /// </summary>
        public double ResultPrice
        {
            get { return _basePrice; }
            set
            {
                if (value >= 0)
                    _resultPrice = value;
                else
                    throw new ArgumentOutOfRangeException();
            }
        }

        /// <summary>
        /// Свойство категории товара
        /// </summary>
        public Category Type
        {
            get { return _type; }
            set
            {
                if (value == Category.All)
                    throw new ArgumentOutOfRangeException();
                else
                    _type = value;
            }
        }
    }
}
