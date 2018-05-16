using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTest
{
    public class Account
    {
        private float _balance;
        private float _minimumBalance = 10.00F;

        public void Deposit(float amount)
        {
            _balance += amount;
        }

        public void Withdraw(float amount)
        {
            _balance -= amount;
        }

        public void TransferFunds(Account destination, float amount)
        {
            if (_balance - amount < _minimumBalance)
                throw new InsufficientFundsException();
            destination.Deposit(amount);
            Withdraw(amount);
        }

        public float Balance
        {
            get { return _balance; }
        }

        
        public float MinimumBalance
        {
            get { return _minimumBalance; }
        }

        public class InsufficientFundsException : ApplicationException
        {
        }


    }
}
