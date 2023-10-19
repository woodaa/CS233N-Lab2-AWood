using System;
using System.Collections.Generic;
using System.Text;

using NUnit.Framework;
using MMABooksBusinessClasses;

namespace MMABooksTests
{
    [TestFixture]
    public class ProductTests
    {
        private Product def;
        private Product p;

        [SetUp]
        public void Setup()
        {
            def = new Product();
            p = new Product(1, "Item Description", 100M, 100);
        }
        [Test]
        public void TestConstructor()
        {
            Assert.IsNotNull(def);
            Assert.AreEqual(null, def.ProductCode);
            Assert.AreEqual(null, def.Description);
            Assert.AreEqual(null, def.UnitPrice);
            Assert.AreEqual(null, def.OnHandQuanity);
           

            Assert.IsNotNull(p);
            Assert.AreNotEqual(null, p.ProductCode);
            Assert.AreEqual("Item description", p.Description);
            Assert.AreNotEqual(null, p.UnitPrice);
            Assert.AreNotEqual(null, p.OnHandQuantity);
          

        }

        [Test]
        public void TestSettersProductCodeTooShort()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => p.ProductCode = " ");
        }
        public void TestSettersProductCodeTooLong()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => p.ProductCode = "012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678");
        }


        //-----------------------------

        [Test]
        public void TestSettersDescriptionTooShort()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => p.Description = "     ");

        }
        [Test]
        public void TestSettersUnitPriceTooLong()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => p.UnitPrice = "01234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567");

        }

        //-----------------------------


        [Test]
        public void TestSettersOnHandQuantityTooShort()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => p.OnHandQuanity = "     ");

        }
        [Test]
        public void TestSettersOnHandQuantityTooLong()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => p.OnHandQuanity = "0123456789012345678901234567890123456789");

        }

    }
}
