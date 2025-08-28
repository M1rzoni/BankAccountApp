using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountApp
{
    public class BankAccount
    {
        public string Owner { get; set; }
        public Guid AccountNumber { get; set; }
        public decimal Balance { get; private set; }

        public BankAccount(string aOwner)
        {
            Owner = aOwner;
            AccountNumber = Guid.NewGuid();
            Balance = 0;
           
        }

        public string Deposite(decimal amount)
        {
            if(amount <= 0)
            return "You can not deposite $" + amount;

            if (amount > 20000)

                return "AML Deposite Limit Reached.";

            Balance += amount;

            return "Deposite completed successfully";

        }

        public string Withdraw(decimal amount)
        {
            if (amount <= 0)
                return "You can  not withdraw $" + amount;

            if (amount > Balance)
                return "You don't have enough money.";

            Balance -= amount;
            return "Withdraw completed successfully";
        }

    }
}
