using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using UnitTest;

namespace CalidadNetTests
{
    [TestClass]
    public class DiscountTests
    {
        private Discount discount;
        [TestInitialize]
        public void Init()
        {
            discount = new Discount();
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), " Sales Amount should not be 'Zero/Negative'")]
        public void If_I_Want_To_Calculate_Discount_And_Income_Amount_0_Should_Return_An_Exception()
        {
        
            discount.calculateDiscount(0);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), " Sales Amount should not be 'Zero/Negative'")]
        public void If_I_Want_To_Calculate_Discount_And_Income_A_Negative_Amount_Should_Return_An_Exception()
        {
            discount.calculateDiscount(-1);
        }
        [TestMethod]
        public void If_I_Want_To_Calculate_The_Discount_Of_Amount_1_I_Should_Return_1()
        {
            Assert.AreEqual(discount.calculateDiscount(1), 1);
        }
        [TestMethod]
        public void If_I_Want_To_Calculate_The_Discount_Of_Amount_999_I_Should_Return_999()
        {
            Assert.AreEqual(discount.calculateDiscount(999), 999);
        }
        [TestMethod]
        public void If_I_Want_To_Calculate_The_Discount_Of_Amount_1000_I_Should_Return_950()
        {
            Assert.AreEqual(discount.calculateDiscount(1000), 950);
        }
        [TestMethod]
        public void If_I_Want_To_Calculate_The_Discount_Of_Amount_1999_I_Should_Return_1899_05()
        {
            Assert.AreEqual(discount.calculateDiscount(1999), 1899.05);
        }
        [TestMethod]
        public void If_I_Want_To_Calculate_The_Discount_Of_Amount_2000_I_Should_Return_1800()
        {
            Assert.AreEqual(discount.calculateDiscount(2000), 1800);
        }
        [TestMethod]
        public void If_I_Want_To_Calculate_The_Discount_Of_Amount_4999_I_Should_Return_4499_1()
        {
            Assert.AreEqual(discount.calculateDiscount(4999), 4499.1);
        }
        [TestMethod]
        public void If_I_Want_To_Calculate_The_Discount_Of_Amount_5000_I_Should_Return_2500()
        {
            Assert.AreEqual(discount.calculateDiscount(5000), 2500);
        }
        [TestMethod]
        public void If_I_Want_To_Calculate_The_Discount_Of_Amount_19999_I_Should_Return_9999_5()
        {
            Assert.AreEqual(discount.calculateDiscount(19999), 9999.5);
        }
    }
}
