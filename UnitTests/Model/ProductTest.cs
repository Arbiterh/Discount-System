using System;
using BusinessLogic;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace UnitTests.Model
{
    [TestFixture]
    internal class ProductTest
    {

        //[TestCase(6.01, TestName = "Тестирование BasePrice при присваивании 6.01.")]
        //[TestCase(246, TestName = "Тестирование BasePrice при присваивании 246.")]
        //[TestCase(double.MaxValue, TestName = "Тестирование BasePrice при присваивании MaxValue.")]
        //[TestCase(double.MaxValue - 1, TestName = "Тестирование BasePrice при присваивании MaxValue - 1.")]
        //[Test]
        //public void BasePriceTest()
        //{
        //    PositiveBasePriceTest1();
        //    PositiveBasePriceTest2();
        //    PositiveBasePriceTest3();
        //    PositiveBasePriceTest4();
        //    NegativeBasePriceTest1();
        //    NegativeBasePriceTest2();
        //    NegativeBasePriceTest3();
        //    NegativeBasePriceTest4();
        //}
        //var product = new Product();
        //Assert.That(() => product.BasePrice = 6.01, Is.EqualTo(6.01), 
        //    "Тестирование BasePrice при присваивании 6.01.");
        //Assert.That(() => product.BasePrice = 246, Is.EqualTo(246));
        //Assert.That(() => product.BasePrice = 0, Throws.Exception.TypeOf<ArgumentOutOfRangeException>());
        ////Assert.That(() => product.BasePrice = 246, Is.True);
        //Assert.That(() => product.BasePrice = double.MaxValue, Is.EqualTo(double.MaxValue));
        //Assert.That(() => product.BasePrice = double.MaxValue - 1, Is.EqualTo(double.MaxValue - 1));
        ////Expect(product.BasePrice = 0, Throws.Exception.TypeOf<ArgumentOutOfRangeException>());
        //Assert.That(() => product.BasePrice = double.MinValue, 
        //    Throws.Exception.TypeOf<ArgumentOutOfRangeException>());
        //Assert.That(() => product.BasePrice = double.MinValue + 1, 
        //    Throws.Exception.TypeOf<ArgumentOutOfRangeException>());
        //[Test]
        //void PositiveBasePriceTest(double price)
        //{
        //    var product = new Product();
        //    Assert.That(() => product.BasePrice = price, Is.EqualTo(price));
        //}
        //[Test]
        //void NegativeBasePriceTest(double price)
        //{
        //    var product = new Product();
        //    Assert.That(() => product.BasePrice = price, Throws.Exception.TypeOf<ArgumentOutOfRangeException>());
        //}

        //PositiveBasePriceTest(6.01);

        //PositiveBasePriceTest(246);
        //PositiveBasePriceTest(double.MaxValue);
        //PositiveBasePriceTest(double.MaxValue - 1);

        //NegativeBasePriceTest(0);
        //NegativeBasePriceTest(double.MinValue);
        //NegativeBasePriceTest(double.MinValue + 1);

            [Test]
            public void PositiveBasePriceTest1()
            {
                var product = new Product();
                Assert.That(() => product.BasePrice = 6.01, Is.EqualTo(6.01));
            }
            [Test]
            public void PositiveBasePriceTest2()
            {
                var product = new Product();
                Assert.That(() => product.BasePrice = 246, Is.EqualTo(246));
            }
            [Test]
            public void PositiveBasePriceTest3()
            {
                var product = new Product();
                Assert.That(() => product.BasePrice = double.MaxValue, Is.EqualTo(double.MaxValue));
            }
            [Test]
            public void PositiveBasePriceTest4()
            {
                var product = new Product();
                Assert.That(() => product.BasePrice = double.MaxValue - 1, Is.EqualTo(double.MaxValue - 1));
            }

            [Test]
            public void NegativeBasePriceTest1()
            {
                var product = new Product();
                Assert.That(() => product.BasePrice = -1, Throws.Exception.TypeOf<ArgumentOutOfRangeException>());
            }
            [Test]
            public void NegativeBasePriceTest2()
            {
                var product = new Product();
                Assert.That(() => product.BasePrice = 0, Throws.Exception.TypeOf<ArgumentOutOfRangeException>());
            }
            [Test]
            public void NegativeBasePriceTest3()
            {
                var product = new Product();
                Assert.That(() => product.BasePrice = double.MinValue, 
                    Throws.Exception.TypeOf<ArgumentOutOfRangeException>());
            }
            [Test]
            public void NegativeBasePriceTest4()
            {
                var product = new Product();
                Assert.That(() => product.BasePrice = double.MinValue + 1, 
                    Throws.Exception.TypeOf<ArgumentOutOfRangeException>());
            }


        [Test]
        public void PositiveResultPriceTest1()
        {
            var product = new Product() {BasePrice = 20};
            Assert.That(() => product.ResultPrice = 15, Is.EqualTo(15));
        }
        [Test]
        public void PositiveResultPriceTest2()
        {
            var product = new Product() { BasePrice = 20 };
            Assert.That(() => product.ResultPrice = 0, Is.EqualTo(0));
        }
        [Test]
        public void PositiveResultPriceTest3()
        {
            var product = new Product() { BasePrice = 20 };
            Assert.That(() => product.ResultPrice = 6.24, Is.EqualTo(6.24));
        }

        [Test]
        public void PositiveResultPriceTest4()
        {
            var product = new Product() {BasePrice = 20};
            Assert.That(() => product.ResultPrice = 20, Is.EqualTo(20));
        }

        [Test]
        public void NegativeResultPriceTest1()
        {
            var product = new Product() { BasePrice = 20 };
            Assert.That(() => product.ResultPrice = 23456, 
                Throws.Exception.TypeOf<ArgumentOutOfRangeException>());
        }
        [Test]
        public void NegativeResultPriceTest2()
        {
            var product = new Product() { BasePrice = 20 };
            Assert.That(() => product.ResultPrice = 23.456, 
                Throws.Exception.TypeOf<ArgumentOutOfRangeException>());
        }
        [Test]
        public void NegativeResultPriceTest3()
        {
            var product = new Product() { BasePrice = 20 };
            Assert.That(() => product.ResultPrice = double.MaxValue, 
                Throws.Exception.TypeOf<ArgumentOutOfRangeException>());
        }
        [Test]
        public void NegativeResultPriceTest4()
        {
            var product = new Product() { BasePrice = 20 };
            Assert.That(() => product.ResultPrice = double.MaxValue - 1, 
                Throws.Exception.TypeOf<ArgumentOutOfRangeException>());
        }
        [Test]
        public void NegativeResultPriceTest5()
        {
            var product = new Product() { BasePrice = 20 };
            Assert.That(() => product.ResultPrice = -1, 
                Throws.Exception.TypeOf<ArgumentOutOfRangeException>());
        }
        [Test]
        public void NegativeResultPriceTest6()
        {
            var product = new Product() { BasePrice = 20 };
            Assert.That(() => product.ResultPrice = double.MinValue, 
                Throws.Exception.TypeOf<ArgumentOutOfRangeException>());
        }
        [Test]
        public void NegativeResultPriceTest7()
        {
            var product = new Product() { BasePrice = 20 };
            Assert.That(() => product.ResultPrice = double.MinValue + 1, 
                Throws.Exception.TypeOf<ArgumentOutOfRangeException>());
        }
        //[Test]
        //[TestCase(6.01, TestName = "Тестирование BasePrice при присваивании 6.01.")]
        //[TestCase(246, TestName = "Тестирование BasePrice при присваивании 246.")]
        //[TestCase(double.MaxValue, TestName = "Тестирование BasePrice при присваивании MaxValue.")]
        //[TestCase(double.MaxValue - 1, TestName = "Тестирование BasePrice при присваивании MaxValue - 1.")]
        //public void PositiveBasePriceTest(double price)
        //{
        //    var product = new Product();
        //    Assert.That(() => product.BasePrice = price, Is.EqualTo(price));
        //}

        //[TestCase(0, TestName = "Тестирование BasePrice при присваивании 0.")]
        //[TestCase(-1, TestName = "Тестирование BasePrice при присваивании -1.")]
        //[TestCase(double.MinValue, TestName = "Тестирование BasePrice при присваивании MinValue.")]
        //[TestCase(double.MinValue + 1, TestName = "Тестирование BasePrice при присваивании MinValue + 1.")]
        //public void NegativeBasePriceTest(double price)
        //{
        //    var product = new Product();
        //    Assert.That(() => product.BasePrice = price, Throws.Exception.TypeOf<ArgumentOutOfRangeException>());
        //}
        //        [Test]

        //        [Test]


        //[Test]
        //[TestCase(0, TestName = "Тестирование BasePrice при присваивании 0.")]
        //[TestCase(-1, TestName = "Тестирование BasePrice при присваивании -1.")]
        //[TestCase(double.MinValue, TestName = "Тестирование BasePrice при присваивании MinValue.")]
        //[TestCase(double.MinValue + 1, TestName = "Тестирование BasePrice при присваивании MinValue + 1.")]
        //public void NegativeBasePriceTest(double price)
        //{
        //    var product = new Product();
        //    Assert.That(() => product.BasePrice = price, Throws.Exception.TypeOf<ArgumentOutOfRangeException>());
        //}
        //[Test]
        //public void BasePriceTest3()
        //{
        //    var product = new Product();
        //    Assert.That(() => product.BasePrice = 246, Is.EqualTo(246));
        //}
        //[Test]
        //public void BasePriceTest4()
        //{
        //    var product = new Product();
        //    Assert.That(() => product.BasePrice = double.MaxValue, Is.EqualTo(double.MaxValue));
        //}
        //[Test]
        //public void BasePriceTest5()
        //{
        //    var product = new Product();
        //    Assert.That(() => product.BasePrice = double.MaxValue - 1, Is.EqualTo(double.MaxValue - 1));
        //}
    }
}
