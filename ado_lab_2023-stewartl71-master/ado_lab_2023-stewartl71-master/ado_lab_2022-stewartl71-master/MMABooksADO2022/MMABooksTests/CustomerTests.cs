using System;
using System.Collections.Generic;
using System.Text;

using NUnit.Framework;
using MMABooksBusinessClasses;

namespace MMABooksTests
{
    [TestFixture]
    public class CustomerTests
    {
        private Customer def;
        private Customer c;

        [SetUp]
        public void Setup()
        {
            def = new Customer();
            c = new Customer(1, "Donald Duck", "101 Main Street", "Orlando", "FL", "10001");
        }
        [Test]
        public void TestConstructor()
        {
            Assert.IsNotNull(def);
            Assert.AreEqual(null, def.Name);
            Assert.AreEqual(null, def.Address);
            Assert.AreEqual(null, def.City);
            Assert.AreEqual(null, def.State);
            Assert.AreEqual(null, def.ZipCode);

            Assert.IsNotNull(c);
            Assert.AreNotEqual(null, c.Name);
            Assert.AreEqual("Donald Duck", c.Name);
            Assert.AreNotEqual(null, c.Address);
            Assert.AreNotEqual(null, c.City);
            Assert.AreNotEqual(null, c.State);
            Assert.AreNotEqual(null, c.ZipCode);

        }

        [Test]
        public void TestSettersNameTooShort()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => c.Name = " ");
        }
        public void TestSettersNameTooLong()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => c.Name = "012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678");
        }


        //-----------------------------

        [Test]
        public void TestSettersAddressTooShort()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => c.Address = "     ");

        }
        [Test]
        public void TestSettersAddressTooLong()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => c.Address = "01234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567");

        }

        //-----------------------------


        [Test]
        public void TestSettersCityTooShort()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => c.City = "     ");

        }
        [Test]
        public void TestSettersCityTooLong()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => c.City = "0123456789012345678901234567890123456789");

        }


        //-----------------------------

        [Test]
        public void TestSettersStateTooShort()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => c.State = "     ");

        }
        [Test]
        public void TestSettersStateTooLong()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => c.State = "0123456789012345678901234567890123456789");

        }


        //-----------------------------

        [Test]
        public void TestSettersZipCodeTooShort()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => c.ZipCode = "     ");

        }
        [Test]
        public void TestSettersZipCodeTooLong()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => c.ZipCode = "0123456789012345678901234567890123456789");

        }
        //-----------------------------

    }
}
