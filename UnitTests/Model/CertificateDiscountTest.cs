using System;
using BusinessLogic;
using NUnit.Framework;

namespace UnitTests.Model
{
    [TestFixture]
    internal class CertificateDiscountTest
    {

        [Test]
        [TestCase(0, TestName = "Тестирование DiscountValue при присваивании 0.")]
        [TestCase(300, TestName = "Тестирование DiscountValue при присваивании 300.")]
        [TestCase(int.MaxValue, TestName = "Тестирование DiscountValue при присваивании MaxValue.")]
        [TestCase(int.MaxValue - 1, TestName = "Тестирование DiscountValue при присваивании MaxValue - 1.")]
        public void PositiveDiscountValueTest(int value)
        {
            var discount = new CertificateDiscount();
            Assert.That(() => discount.DiscountValue = value, Is.EqualTo(value));
        }

        [Test]
        [TestCase(-1, TestName = "Тестирование DiscountValue при присваивании -1.")]
        [TestCase(int.MinValue, TestName = "Тестирование DiscountValue при присваивании MinValue.")]
        [TestCase(int.MinValue + 1, TestName = "Тестирование DiscountValue при присваивании MinValue + 1.")]
        public void NegativeDiscountValueTest(int value)
        {
            var discount = new CertificateDiscount();
            Assert.That(() => discount.DiscountValue = value, Throws.Exception.TypeOf<ArgumentOutOfRangeException>());
        }

        [Test]
        [TestCase(200, 100, Category.All, Category.Food, TestName = "Тестирование DoDiscount c правильными категориями.")]
        [TestCase(100, 200, Category.Food, Category.Food, TestName = "Тестирование DoDiscount c правильными одинаковыми категориями.")]
        [TestCase(200, 100, Category.Food, Category.Chemistry, TestName = "Тестирование DoDiscount c неправильными категориями.")]
        public void DoDiscountCategoryPriceTest(double price, int discountValue, Category discountCategory,
            Category productCategory)
        {
            var product = new Product() { BasePrice = price, ResultPrice = price, Type = productCategory };

            var discount = new CertificateDiscount() { DiscountValue = discountValue, CategoryOfProduct = discountCategory };
            discount.DoDiscount(product);

            if (discount.CategoryOfProduct != product.Type && discount.CategoryOfProduct != Category.All)
            {
                Assert.That(() => product.ResultPrice, Is.EqualTo(price));
            }
        }

        [Test]
        [TestCase(200, 100, Category.All, Category.Food, TestName = "Тестирование DoDiscount c правильными категориями.")]
        [TestCase(100, 200, Category.Food, Category.Food, TestName = "Тестирование DoDiscount c правильными одинаковыми категориями.")]
        [TestCase(200, 100, Category.Food, Category.Chemistry, TestName = "Тестирование DoDiscount c неправильными категориями.")]
        public void DoDiscountCategoryDiscountValueTest(double price, int discountValue, Category discountCategory,
            Category productCategory)
        {
            var product = new Product() { BasePrice = price, ResultPrice = price, Type = productCategory };

            var discount = new CertificateDiscount() { DiscountValue = discountValue, CategoryOfProduct = discountCategory };
            discount.DoDiscount(product);

            if (discount.CategoryOfProduct != product.Type && discount.CategoryOfProduct != Category.All)
            {
                Assert.That(() => discount.DiscountValue, Is.EqualTo(discountValue));
            }
        }

        [Test]
        [TestCase(200, 100, Category.Food, Category.Food, TestName = "Тестирование DoDiscount c правильными одинаковыми категориями и значением скидки меньше цены.")]
        [TestCase(100, 100, Category.Food, Category.Food, TestName = "Тестирование DoDiscount c правильными одинаковыми категориями и значением скидки равным цене.")]
        [TestCase(100.01, 100, Category.Food, Category.Food, TestName = "Тестирование DoDiscount c правильными одинаковыми категориями и значением скидки чуть меньше цены.")]
        public void DoDiscountDiscountValueLessPriceTest(double price, int discountValue, Category discountCategory,
            Category productCategory)
        {
            var product = new Product() { BasePrice = price, ResultPrice = price, Type = productCategory };

            var discount = new CertificateDiscount() { DiscountValue = discountValue, CategoryOfProduct = discountCategory };
            discount.DoDiscount(product);

            if (discount.CategoryOfProduct != product.Type && discount.CategoryOfProduct != Category.All) return;
            if (discount.DiscountValue <= product.BasePrice)
                Assert.That(() => product.ResultPrice, Is.EqualTo(price - discountValue));
        }

        [Test]
        [TestCase(200, 100, Category.Food, Category.Food, TestName = "Тестирование DoDiscount c правильными одинаковыми категориями и значением скидки меньше цены.")]
        [TestCase(100, 100, Category.Food, Category.Food, TestName = "Тестирование DoDiscount c правильными одинаковыми категориями и значением скидки равным цене.")]
        [TestCase(100.01, 100, Category.Food, Category.Food, TestName = "Тестирование DoDiscount c правильными одинаковыми категориями и значением скидки чуть меньше цены.")]
        public void DoDiscountDiscountValueLessValueTest(double price, int discountValue, Category discountCategory,
            Category productCategory)
        {
            var product = new Product() { BasePrice = price, ResultPrice = price, Type = productCategory };

            var discount = new CertificateDiscount() { DiscountValue = discountValue, CategoryOfProduct = discountCategory };
            discount.DoDiscount(product);

            if (discount.CategoryOfProduct != product.Type && discount.CategoryOfProduct != Category.All) return;
            if (discount.DiscountValue <= product.BasePrice)
                Assert.That(() => discount.DiscountValue, Is.EqualTo(0));
        }

        [Test]
        [TestCase(100, 200, Category.Food, Category.Food, TestName = "Тестирование DoDiscount c правильными одинаковыми категориями и значением скидки больше цены.")]
        [TestCase(100, 101, Category.Food, Category.Food, TestName = "Тестирование DoDiscount c правильными одинаковыми категориями и значением скидки чуть больше цены.")]
        public void DoDiscountDiscountValueBiggerPriceTest(double price, int discountValue, Category discountCategory, Category productCategory)
        {
            var product = new Product() { BasePrice = price, ResultPrice = price, Type = productCategory };

            var discount = new CertificateDiscount() { DiscountValue = discountValue, CategoryOfProduct = discountCategory };
            discount.DoDiscount(product);

            if (discount.CategoryOfProduct != product.Type && discount.CategoryOfProduct != Category.All) return;
            if (!(discount.DiscountValue <= product.BasePrice))
                Assert.That(() => product.ResultPrice, Is.EqualTo(0));
        }

        [Test]
        [TestCase(100, 200, Category.Food, Category.Food, TestName = "Тестирование DoDiscount c правильными одинаковыми категориями и значением скидки больше цены.")]
        [TestCase(100, 101, Category.Food, Category.Food, TestName = "Тестирование DoDiscount c правильными одинаковыми категориями и значением скидки чуть больше цены.")]
        public void DoDiscountDiscountValueBiggerValueTest(double price, int discountValue, Category discountCategory, Category productCategory)
        {
        var product = new Product() { BasePrice = price, ResultPrice = price, Type = productCategory };

        var discount = new CertificateDiscount() { DiscountValue = discountValue, CategoryOfProduct = discountCategory };
        discount.DoDiscount(product);

        if (discount.CategoryOfProduct != product.Type && discount.CategoryOfProduct != Category.All) return;
        if (!(discount.DiscountValue <= product.BasePrice))
            Assert.That(() => discount.DiscountValue, Is.EqualTo(discountValue - price));
        }
    }
}
