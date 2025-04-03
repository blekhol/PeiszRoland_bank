using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank
{
    internal abstract class BankAccount : BankingService
    {
        protected double balance;

        public BankAccount(Owner owner) : base(owner)
        {

        }

        public double Balance { get => balance; }

        public void Deposit(double amount)
        {
            balance = amount;
        }

        public abstract bool Withdraw(double amount);
    }
}
