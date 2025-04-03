using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank
{
    internal class Bank
    {
        private int maxAccountCount;
        private List<BankAccount> accounts = new();

        public Bank(int maxAccountCount)
        {
            this.maxAccountCount = maxAccountCount;
        }

        public BankAccount NewAccount(string owner, double creditLimit = 0.0f)
        {
            Owner o = new Owner(owner);

            if (creditLimit == 0.0f)
            {
                return new SavingsAccount(o);
            }
            return new CreditAccount(o, creditLimit);
        }

        public double TotalBalance(Owner owner)
        {
            double sum = 0;
            foreach (BankAccount account in accounts)
            {
                if (account.Owner == owner)
                {
                    sum += account.Balance;
                }
            }

            return sum;
        }

        public BankAccount MaxBalanceAccount(Owner owner)
        {
            double max = 0;
            BankAccount maxAccount = accounts[0];

            foreach (BankAccount account in accounts)
            {
                if (account.Owner == owner)
                {
                    if (account.Balance > maxAccount.Balance)
                    {
                        max = account.Balance;
                        maxAccount = account;
                    }
                }
            }

            return maxAccount;
        }

        public double TotalCreditLimit()
        {
            double sum = 0;

            foreach (BankAccount account in accounts)
            {
                if(account is CreditAccount)
                {
                    sum += account.Balance;
                }
            }
            return sum;
        }
    }
}
