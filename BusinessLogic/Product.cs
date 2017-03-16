using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    /// <summary>
    /// Класс товара
    /// </summary>
    class Product
    {
        /// <summary>
        /// Поле имени товара, по умолчанию Empty
        /// </summary>
        private string _name = string.Empty;
        /// <summary>
        /// Поле порядкового номера
        /// </summary>
        private int _id;
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
        /// Свойство порядкового номера
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Свойство цены, без учета скидки
        /// </summary>
        public double BasePrice { get; set; }
        /// <summary>
        /// Свойство цены с учетом скидки
        /// </summary>
        public double ResultPrice { get; set; }
        /// <summary>
        /// Свойство категории товара
        /// </summary>
        public Category Type { get; set; }

    }
}
