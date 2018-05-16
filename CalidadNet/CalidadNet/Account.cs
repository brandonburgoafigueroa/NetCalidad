using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTest
{
    public class Account
    {
        private float balance;
        private float minimumBalance = 10.00F;

        public void Deposit(float amount)
        {
            balance += amount;
        }

        public void Withdraw(float amount)
        {
            balance -= amount;
        }

        public void TransferFunds(Account destination, float amount)
        {
            if (balance - amount < minimumBalance)
                throw new InsufficientFundsException();
            destination.Deposit(amount);
            Withdraw(amount);
        }

        public float Balance
        {
            get { return balance; }
        }

        
        public float MinimumBalance
        {
            get { return minimumBalance; }
        }

        public class InsufficientFundsException : ApplicationException
        {
        }


    }
}
