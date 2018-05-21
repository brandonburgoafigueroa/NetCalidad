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
        private Account source;
        private Account destination;
        [TestInitialize]
        public void Init()
        {
            source = new Account();
            destination = new Account();
        }
        [TestMethod]
        public void TestTransferFunds()
        {
            source.Deposit(200.00F);
            destination.Deposit(150.00F);
            source.TransferFunds(destination, 100.00F);
            Assert.AreEqual(250.00F, destination.Balance);
            Assert.AreEqual(100.00F, source.Balance);
        }
        [TestMethod]
        [ExpectedException(typeof(Account.InsufficientFundsException))]
        public void If_I_Deposit_In_My_200F_Account_And_Transfer_201F_I_Should_Return_Exception()
        {
            source.Deposit(200F);
            destination.Deposit(0F);
            source.TransferFunds(destination, 201F);
        }
        [TestMethod]
        public void If_I_Create_An_Account_And_Obtain_Its_Minimum_Balance_I_Should_Return_10_00F()
        {
            Assert.AreEqual(source.MinimumBalance, 10.00F);
        }
        [TestMethod]
        public void If_I_Create_A_Deposit_Account_200_And_I_Get_My_Balance_I_Should_Return_200()
        {
            source.Deposit(200F);
            Assert.AreEqual(source.Balance, 200F);
        }
        [TestMethod]
        [ExpectedException(typeof(Account.InsufficientFundsException))]
        public void If_I_Create_A_Deposit_Account_200_And_Withdrawal_201_Should_I_Return_Exception ()
        {
            source.Deposit(200F);
            source.Withdraw(201F);
            Assert.AreEqual(source.Balance, 200F);
        }


    }
}

