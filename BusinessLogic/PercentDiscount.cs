using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    /// <summary>
    /// Реализация процентной скидки
    /// </summary>
    class PercentDiscount : IDiscount
    {
        /// <summary>
        /// Поле значения скидки, по умолчанию 0
        /// </summary>
        private int _discountValue = 0;
        /// <summary>
        /// Поле значения категории товаров, на которую распространяется скидка, по умолчанию All
        /// </summary>
        private Category _categoryOfProduct = Category.All;
        /// <summary>
        /// Свойство значения скидки, ожидаемое значение от 0 до 100
        /// </summary>
        public int DiscountValue
        {
            get { return _discountValue; }
            set
            {
                if (value >= 0 && value <= 100)
                    _discountValue = value;
                else
                    throw new ArgumentOutOfRangeException();
            }
        }
        /// <summary>
        /// Свойство категории продукта, на которую распространяется скидка
        /// </summary>
        public Category CategoryOfProduct
        {
            get { return _categoryOfProduct; }
            set { return value; }
        }
        /// <summary>
        /// Метод, рассчитывающий итоговую цену товара с учетом скидки
        /// </summary>
        /// <param name="product">Экземпляр продукта, для расчета с учетом скидки</param>
        public void DoDiscount(Product product)
        {
            product.ResultPrice = product.BasePrice * (1 - (DiscountValue * 0.01));
        }
    }
}
