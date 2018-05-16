using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using UnitTest;

namespace CalidadNetTests
{

    [TestClass]
    public class AccountTest
    {
        [TestMethod]
        public void TestTransferFunds()
        {
            Account source = new Account();
            source.Deposit(200.00F);
            Account destination = new Account();
            destination.Deposit(150.00F);
            source.TransferFunds(destination, 100.00F);
            Assert.AreEqual(250.00F, destination.Balance);
            Assert.AreEqual(100.00F, source.Balance);
        }
        [TestMethod]
        [ExpectedException(typeof(Account.InsufficientFundsException))]
        public void If_I_Deposit_In_My_200F_Account_And_Transfer_201F_I_Should_Return_Exception()
        {
            Account source = new Account();
            source.Deposit(200F);
            Account destination = new Account();
            destination.Deposit(0F);
            source.TransferFunds(destination, 201F);
        }
        [TestMethod]
        public void If_I_Create_An_Account_And_Obtain_Its_Minimum_Balance_I_Should_Return_10_00F()
        {
            Account account = new Account();
            Assert.AreEqual(account.MinimumBalance, 10.00F);
        }

    }
}

