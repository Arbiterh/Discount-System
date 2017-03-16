using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    /// <summary>
    /// Интерфейс Скидки
    /// </summary>
    interface IDiscount
    {
        /// <summary>
        /// Свойство значения скидки
        /// </summary>
        int DiscountValue { get; set; }
        /// <summary>
        /// Свойство категории товара, на которую распространяется скидка
        /// </summary>
        Category CategoryOfProduct { get; set; }
        /// <summary>
        /// Метод, рассчитывающий итоговую цену товара с учетом скидки
        /// </summary>
        /// <param name="product">Экземпляр продукта, для расчета цены с учетом скидки</param>
        void DoDiscount(Product product);
    }
}
