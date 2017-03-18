using System;

namespace BusinessLogic
{
    /// <summary>
    /// Реализация процентной скидки
    /// </summary>
    public class PercentDiscount : IDiscount
    {
        /// <summary>
        /// Поле значения скидки, по умолчанию 0
        /// </summary>
        private int _discountValue = 0;
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
        /// Свойство категории товара, на которую распространяется скидка, по умолчанию All
        /// </summary>
        public Category CategoryOfProduct { get; set; } = Category.All;
        /// <summary>
        /// Метод, рассчитывающий итоговую цену товара с учетом скидки
        /// </summary>
        /// <param name="product">Экземпляр продукта, для расчета цены с учетом скидки</param>
        public void DoDiscount(Product product)
        {
            product.ResultPrice = product.BasePrice * (1 - (DiscountValue * 0.01));
        }
    }
}
