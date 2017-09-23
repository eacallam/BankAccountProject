using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProject
{
    class CheckingAccount : Account
    {
        //Needs 1 constructor


        //METHODS
        public override decimal Deposit(decimal depositAmount)
        {
            AccountBalance += depositAmount;
            return AccountBalance;
        }

        public override decimal Withdraw(decimal withdrawAmount)
        {
            if (withdrawAmount > AccountBalance)
            {
                Console.WriteLine("You do not have enough money in the account to withdraw this amount.");
                return AccountBalance;
            }
            else
            {
                AccountBalance -= withdrawAmount;
                return AccountBalance;
            }
        }

        //CONSTRUCTOR
        public CheckingAccount(int accountNumber, decimal accountBalance)
        {
            this.AccountNumber = accountNumber;
            this.AccountBalance = accountBalance;                
        }
    }
}
