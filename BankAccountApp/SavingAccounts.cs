using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountApp
{
    internal class SavingAccounts:BankAccount
    {

        public decimal InterestRate { get; set; }   

        public SavingAccounts(string aOwner,decimal aInterestRate):base(aOwner + " (" + aInterestRate + "%)")
        {
            
            InterestRate = aInterestRate;

        }
    }
}
