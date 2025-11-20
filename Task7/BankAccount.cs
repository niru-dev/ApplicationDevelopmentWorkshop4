using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7
{
    public class BankAccount
    {
        private decimal _balance;
        public string Owner { get; }

        public decimal Balance => _balance;

        public BankAccount(string owner, decimal initialBalance = 0m)
        {
            Owner = owner ?? throw new ArgumentNullException(nameof(owner));
            if (initialBalance < 0) throw new ArgumentOutOfRangeException(nameof(initialBalance), "Initial balance cannot be negative.");
            _balance = initialBalance;
        }

        public void Deposit(decimal amount)
        {
            if (amount <= 0) throw new ArgumentOutOfRangeException(nameof(amount), "Deposit amount must be positive.");
            _balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (amount <= 0) throw new ArgumentOutOfRangeException(nameof(amount), "Withdrawal amount must be positive.");
            if (amount > _balance) throw new InvalidOperationException("Insufficient funds.");
            _balance -= amount;
        }
    }


}