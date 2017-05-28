using System;
using BusinessLogic;
using NUnit.Framework;
//using NUnit.Framework.Internal;

namespace UnitTests.Model
{
    [TestFixture]
    internal class ProductTest
    {

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
    }
}
