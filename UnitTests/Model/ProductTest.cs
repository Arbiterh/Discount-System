using System;
using BusinessLogic;
using NUnit.Framework;

namespace UnitTests.Model
{
    [TestFixture]
    internal class ProductTest
    {

        [Test]
        [TestCase(6.01, TestName = "Тестирование BasePrice при присваивании 6.01.")]
        [TestCase(246, TestName = "Тестирование BasePrice при присваивании 246.")]
        [TestCase(double.MaxValue, TestName = "Тестирование BasePrice при присваивании MaxValue.")]
        [TestCase(double.MaxValue - 1, TestName = "Тестирование BasePrice при присваивании MaxValue - 1.")]
        public void PositiveBasePriceTest(double price)
        {
            var product = new Product();
            Assert.That(() => product.BasePrice = price, Is.EqualTo(price));
        }

        [Test]
        [TestCase(0, TestName = "Тестирование BasePrice при присваивании 0.")]
        [TestCase(-1, TestName = "Тестирование BasePrice при присваивании -1.")]
        [TestCase(double.MinValue, TestName = "Тестирование BasePrice при присваивании MinValue.")]
        [TestCase(double.MinValue + 1, TestName = "Тестирование BasePrice при присваивании MinValue + 1.")]
        public void NegativeBasePriceTest(double price)
        {
            var product = new Product();
            Assert.That(() => product.BasePrice = price, Throws.Exception.TypeOf<ArgumentOutOfRangeException>());
        }

        [Test]
        [TestCase(15, TestName = "Тестирование ResultPrice при присваивании 15.")]
        [TestCase(0, TestName = "Тестирование ResultPrice при присваивании 0.")]
        [TestCase(6.24, TestName = "Тестирование ResultPrice при присваивании 6.24.")]
        [TestCase(20, TestName = "Тестирование ResultPrice при присваивании 20.")]
        public void PositiveResultPriceTest(double price)
        {
            var product = new Product() { BasePrice = 20 };
            Assert.That(() => product.ResultPrice = price, Is.EqualTo(price));
        }

        [Test]
        [TestCase(23456, TestName = "Тестирование ResultPrice при присваивании 23456.")]
        [TestCase(23.456, TestName = "Тестирование ResultPrice при присваивании 23.456.")]
        [TestCase(double.MaxValue, TestName = "Тестирование ResultPrice при присваивании double.MaxValue.")]
        [TestCase(double.MaxValue - 1, TestName = "Тестирование ResultPrice при присваивании double.MaxValue - 1.")]
        [TestCase(-1, TestName = "Тестирование ResultPrice при присваивании -1.")]
        [TestCase(double.MinValue, TestName = "Тестирование ResultPrice при присваивании double.MinValue.")]
        [TestCase(double.MinValue + 1, TestName = "Тестирование ResultPrice при присваивании double.MinValue + 1.")]
        public void NegativeResultPriceTest(double price)
        {
            var product = new Product() { BasePrice = 20 };
            Assert.That(() => product.ResultPrice = price,
                Throws.Exception.TypeOf<ArgumentOutOfRangeException>());
        }

        [Test]
        [TestCase(Category.Food, TestName = "Тестирование Type при присваивании Category.Food.")]
        [TestCase(Category.Alcohol, TestName = "Тестирование Type при присваивании Category.Alcohol.")]
        [TestCase(Category.Chemistry, TestName = "Тестирование Type при присваивании Category.Chemistry.")]
        public void PositiveCategoryTest(Category category)
        {
            var product = new Product();
            Assert.That(() => product.Type = category, Is.EqualTo(category));
        }

        [Test]
        [TestCase(Category.All, TestName = "Тестирование Type при присваивании Category.All.")]
        public void NegativeCategoryTest(Category category)
        {
            var product = new Product();
            Assert.That(() => product.Type = category, 
                Throws.Exception.TypeOf<ArgumentOutOfRangeException>());
        }
    }
}
