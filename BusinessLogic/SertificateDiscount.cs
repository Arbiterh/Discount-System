using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    /// <summary>
    /// Реализация сертификатной скидки
    /// </summary>
    class SertificateDiscount : IDiscount
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
        /// Свойство значения скидки, ожидаемое значение не меньше 0
        /// </summary>
        public int DiscountValue
        {
            get { return _discountValue; }
            set
            {
                if (value >= 0)
                    _discountValue = value;
                else
                    throw new ArgumentOutOfRangeException();
            }
        }
        /// <summary>
        /// Свойство категории товара
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
            if (DiscountValue <= product.BasePrice)
                product.ResultPrice = product.BasePrice - DiscountValue;
            else
                product.ResultPrice = 0;
        }
    }
}
