using System;

namespace BusinessLogic
{
    /// <summary>
    /// Реализация сертификатной скидки
    /// </summary>
    public class SertificateDiscount : IDiscount
    {
        /// <summary>
        /// Поле значения скидки, по умолчанию 0
        /// </summary>
        private int _discountValue = 0;
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
        /// Свойство категории товара, на которую распространяется скидка, по умолчанию All
        /// </summary>
        public Category CategoryOfProduct { get; set; } = Category.All;
        /// <summary>
        /// Метод, рассчитывающий итоговую цену товара с учетом скидки
        /// </summary>
        /// <param name="product">Экземпляр продукта, для расчета цены с учетом скидки</param>
        public void DoDiscount(Product product)
        {
            if (CategoryOfProduct != product.Type && CategoryOfProduct != Category.All) return;
            if (DiscountValue <= product.BasePrice)
            {
                product.ResultPrice = product.BasePrice - DiscountValue;
                DiscountValue -= (int) (product.ResultPrice - product.BasePrice);
            }
            else
            {
                product.ResultPrice = 0;
                DiscountValue -= (int) product.BasePrice;
            }
        }
    }
}
