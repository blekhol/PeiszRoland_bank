using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank
{
    internal class SavingsAccount : BankAccount
    {
        private double baseInterest;

        public SavingsAccount(Owner owner) : base(owner)
        {
            Interest = baseInterest;
        }

        public double Interest { get => Interest; set => Interest = value; }

        public override bool Withdraw(double amount)
        {
            if (balance - amount < 0)
            {
                return false;
            }
            balance -= amount;
            return true;
        }

        public void AddInterest()
        {
            balance += Interest * balance;
        }
    }
}
