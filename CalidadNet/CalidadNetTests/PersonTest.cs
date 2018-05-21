using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using UnitTest;

namespace CalidadNetTests
{
    [TestClass]
    public class PersonTest
    {
        private Person PersonWithParamethersConstructor;
        private Person PersonWithoutParamethersConstructor;
        [TestInitialize]
        public void Init()
        {
            string FName = "Chili";
            string LName = "Willy";
            int Age = 30;
            PersonWithParamethersConstructor = new Person(FName, LName, Age);
            PersonWithoutParamethersConstructor = new Person();
        }

        [TestMethod]
        public void If_I_Create_A_Person_With_An_Empty_Constructor_And_I_Get_Your_Age_Should_Return_Zero()
        {
            Assert.AreEqual(PersonWithoutParamethersConstructor.Age, 0);
        }
        [TestMethod]
        public void If_I_Create_A_Person_With_An_Empty_Constructor_And_I_Get_Your_FullName_Should_Return_A_Space()
        {
            
            Assert.AreEqual(PersonWithoutParamethersConstructor.FullName, " ");
        }
        [TestMethod]
        public void If_I_Create_A_Person_With_An_Empty_Constructor_And_I_Get_Your_CashBalance_Should_Return_0()
        {
            
            Assert.AreEqual(PersonWithoutParamethersConstructor.CashBalance, 0);
        }
        [TestMethod]
        public void If_I_Create_A_Person_With_An_Empty_Constructor_And_I_BuyCar_With_A_Price_Of_100_Should_Return_False()
        {
            
            Assert.AreEqual(PersonWithoutParamethersConstructor.BuyCar(100), false);
            Assert.AreEqual(PersonWithoutParamethersConstructor.CashBalance, 0);
        }
        [TestMethod]
        public void If_I_Create_A_Person_With_An_Empty_Constructor_And_I_BuyCar_With_A_Price_Of_0_Should_Return_True()
        {
            
            Assert.AreEqual(PersonWithoutParamethersConstructor.BuyCar(0), true);
            Assert.AreEqual(PersonWithoutParamethersConstructor.CashBalance, 0);
        }
        [TestMethod]
        public void If_I_Create_A_Person_With_An_Empty_Constructor_And_I_BuyCar_With_A_Price_Of_Negative_Should_Return_False()
        {
            Assert.AreEqual(PersonWithoutParamethersConstructor.BuyCar(-1), false);
            Assert.AreEqual(PersonWithoutParamethersConstructor.CashBalance, 0);
        }
        [TestMethod]
        public void If_You_Created_One_Person_Per_Builder_With_Parameters_And_Get_Your_Age_Should_Return_The_Age_You_Gave()
        {
           
            Assert.AreEqual(PersonWithParamethersConstructor.Age, 30);
        }
        [TestMethod]
        public void If_You_Created_One_Person_Per_Builder_With_Parameters_And_Get_Your_FullName_Should_Return_The_FName_A_Space_LName_You_Gave()
        {
            Assert.AreEqual(PersonWithParamethersConstructor.FullName, "Chili Willy");
        }
        [TestMethod]
        public void If_You_Created_One_Person_Per_Builder_With_Parameters_And_Get_Your_CashBalance_Should_Return_100000()
        {

            Assert.AreEqual(PersonWithParamethersConstructor.CashBalance, 100000);
        }
        [TestMethod]
        public void If_You_Created_One_Person_Per_Builder_With_Parameters_And_I_BuyCar_With_A_Price_Of_100_Should_Return_True()
        {
            Assert.AreEqual(PersonWithParamethersConstructor.BuyCar(100), true);
            Assert.AreEqual(PersonWithParamethersConstructor.CashBalance, 99900);
        }
        [TestMethod]
        public void If_You_Created_One_Person_Per_Builder_With_Parameters_And_I_BuyCar_With_A_Price_Of_100001_Should_Return_False()
        {
            Assert.AreEqual(PersonWithParamethersConstructor.BuyCar(100001), false);
            Assert.AreEqual(PersonWithParamethersConstructor.CashBalance, 100000);
        }
       
    }
}
