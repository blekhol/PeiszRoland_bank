using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank
{
    internal abstract class BankingService
    {
        private Owner owner;

        protected BankingService(Owner owner)
        {
            this.owner = owner;
        }

        internal Owner Owner { get => owner; }
    }
}
