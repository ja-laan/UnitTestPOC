using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestPOC
{
    public class BankAccount
    {
        private BankAccount() { }

        public BankAccount(string customerName, double balance)
        {
            CustomerName = customerName;
            Balance = balance;
        }

        public string CustomerName { get; }

        public double Balance { get; private set; }

        public void Debit(double amount)
        {
            if (amount > Balance)
            {
                throw new ArgumentOutOfRangeException("amount");
            }

            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("amount");
            }

            Balance -= amount; 
        }

        public void Credit(double amount)
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("amount");
            }

            Balance += amount;
        }
    }
}
