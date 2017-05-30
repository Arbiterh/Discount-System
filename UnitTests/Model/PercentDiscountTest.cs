using System;
using BusinessLogic;
using NUnit.Framework;

namespace UnitTests.Model
{
    [TestFixture]
    internal class PercentDiscountTest
    {

        [Test]
        [TestCase(0, TestName = "Тестирование DiscountValue при присваивании 0.")]
        [TestCase(100, TestName = "Тестирование DiscountValue при присваивании 100.")]
        [TestCase(50, TestName = "Тестирование DiscountValue при присваивании 50.")]
        [TestCase(int.MaxValue, TestName = "Тестирование DiscountValue при присваивании MaxValue.")]
        [TestCase(int.MaxValue - 1, TestName = "Тестирование DiscountValue при присваивании MaxValue - 1.")]
        public void PositiveDiscountValueTest(int value)
        {
            var discount = new PercentDiscount();
            Assert.That(() => discount.DiscountValue = value, Is.EqualTo(value));
        }

        [Test]
        [TestCase(-1, TestName = "Тестирование DiscountValue при присваивании -1.")]
        [TestCase(int.MinValue, TestName = "Тестирование DiscountValue при присваивании MinValue.")]
        [TestCase(int.MinValue + 1, TestName = "Тестирование DiscountValue при присваивании MinValue + 1.")]
        [TestCase(101, TestName = "Тестирование DiscountValue при присваивании 101.")]
        [TestCase(int.MaxValue, TestName = "Тестирование DiscountValue при присваивании MaxValue.")]
        [TestCase(int.MaxValue - 1, TestName = "Тестирование DiscountValue при присваивании MaxValue - 1.")]
        public void NegativeDiscountValueTest(int value)
        {
            var discount = new PercentDiscount();
            Assert.That(() => discount.DiscountValue = value, Throws.Exception.TypeOf<ArgumentOutOfRangeException>());
        }

        [Test]
        [TestCase(100, 50, Category.All, Category.Food, TestName = "Тестирование DoDiscount c правильными категориями.")]
        [TestCase(301.36, 80, Category.Food, Category.Food, TestName = "Тестирование DoDiscount c правильными одинаковыми категориями.")]
        [TestCase(100, 50, Category.Food, Category.Chemistry, TestName = "Тестирование DoDiscount c неправильными категориями.")]
        public void DoDiscountCategoryPriceTest(double price, int discountValue, Category discountCategory,
            Category productCategory)
        {
            var product = new Product() { BasePrice = price, ResultPrice = price, Type = productCategory };

            var discount = new PercentDiscount() { DiscountValue = discountValue, CategoryOfProduct = discountCategory };
            discount.DoDiscount(product);

            if (discount.CategoryOfProduct == product.Type || discount.CategoryOfProduct == Category.All)
            {
                Assert.That(() => product.ResultPrice, Is.EqualTo(price * (1 - (discountValue * 0.01))));
            }
        }
    }
}
