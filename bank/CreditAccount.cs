using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank
{
    internal class CreditAccount : BankAccount
    {
        private double creditLimit;

        public CreditAccount(Owner owner, double creditLimit) : base(owner)
        {
            this.creditLimit = creditLimit;
        }

        public double CreditLimit { get => creditLimit; }

        public override bool Withdraw(double amount)
        {
            if (creditLimit > balance - amount)
            {
                return false;
            }
            balance -= amount;
            return true;
        }
    }
}
