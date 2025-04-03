using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank
{
    internal class BankCard : BankingService
    {
        private double accountBalance;
        private string cardNumber;

        public BankCard(Owner owner, double accountBalance, string cardNumber) : base(owner)
        {
            this.accountBalance = accountBalance;
            this.cardNumber = cardNumber;
        }

        public double AccountBalance { get => accountBalance; }
        public string CardNumber { get => cardNumber; }

        public bool Purchase(double amount)
        {
            if (accountBalance - amount < 0)
            {
                return false;
            }
            accountBalance -= amount;
            return true;
        }
    }
}
