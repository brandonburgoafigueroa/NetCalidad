using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using UnitTest;

namespace UnitTest
{
    [TestClass]
    public class PersonTest
    {
        [TestMethod]
        public void If_I_Create_A_Person_With_An_Empty_Constructor_And_I_Get_Your_Age_Should_Return_Zero()
        {
            Person person = new Person();
            Assert.AreEqual(person.Age, 0);
        }
        [TestMethod]
        public void If_I_Create_A_Person_With_An_Empty_Constructor_And_I_Get_Your_FullName_Should_Return_A_Space()
        {
            Person person = new Person();
            Assert.AreEqual(person.FullName, " ");
        }
        [TestMethod]
        public void If_I_Create_A_Person_With_An_Empty_Constructor_And_I_Get_Your_CashBalance_Should_Return_0()
        {
            Person person = new Person();
            Assert.AreEqual(person.CashBalance, 0);
        }
        [TestMethod]
        public void If_I_Create_A_Person_With_An_Empty_Constructor_And_I_BuyCar_With_A_Price_Of_100_Should_Return_False()
        {
            Person person = new Person();
            Assert.AreEqual(person.BuyCar(100), false);
        }
        [TestMethod]
        public void If_I_Create_A_Person_With_An_Empty_Constructor_And_I_BuyCar_With_A_Price_Of_0_Should_Return_True()
        {
            Person person = new Person();
            Assert.AreEqual(person.BuyCar(0), true);
        }

        [TestMethod]
        public void If_You_Created_One_Person_Per_Builder_With_Parameters_And_Get_Your_Age_Should_Return_The_Age_You_Gave()
        {
            string FName = "Chili";
            string LName = "Willy";
            int Age = 30;
            Person person = new Person(FName, LName, Age);
            Assert.AreEqual(person.Age, 30);
        }
        [TestMethod]
        public void If_You_Created_One_Person_Per_Builder_With_Parameters_And_Get_Your_FullName_Should_Return_The_FName_A_Space_LName_You_Gave()
        {
            string FName = "Chili";
            string LName = "Willy";
            int Age = 30;
            Person person = new Person(FName, LName, Age);
            Assert.AreEqual(person.FullName, "Chili Willy");
        }
        [TestMethod]
        public void If_You_Created_One_Person_Per_Builder_With_Parameters_And_Get_Your_CashBalance_Should_Return_100000()
        {
            string FName = "Chili";
            string LName = "Willy";
            int Age = 30;
            Person person = new Person(FName, LName, Age);
            Assert.AreEqual(person.CashBalance, 100000);
        }
        [TestMethod]
        public void If_You_Created_One_Person_Per_Builder_With_Parameters_And_I_BuyCar_With_A_Price_Of_100_Should_Return_True()
        {
            string FName = "Chili";
            string LName = "Willy";
            int Age = 30;
            Person person = new Person(FName, LName, Age);
            Assert.AreEqual(person.BuyCar(100), true);
        }
        [TestMethod]
        public void If_You_Created_One_Person_Per_Builder_With_Parameters_And_I_BuyCar_With_A_Price_Of_100001_Should_Return_False()
        {
            string FName = "Chili";
            string LName = "Willy";
            int Age = 30;
            Person person = new Person(FName, LName, Age);
            Assert.AreEqual(person.BuyCar(100001), false);
        }


    }
}
