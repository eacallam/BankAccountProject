using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProject
{
    class SavingsAccount : Account
    {
        //Note: Savings Account must include a minimum balance.User cannot withdraw money if balance will drop below minimum.
        //1 property
        //1 constructor


        //PROPERTY
        public decimal MinimumBalance { get; set; }

        //CONSTRUCTOR
        public SavingsAccount(int accountNumber, decimal accountBalance, decimal minimumBalance)
        {
            this.AccountNumber = accountNumber;
            this.AccountBalance = accountBalance;
            this.MinimumBalance = minimumBalance;
        }


        //METHODS
        public override decimal Deposit(decimal depositAmount)
        {
            AccountBalance += depositAmount;
            return AccountBalance;
        }

        public override decimal Withdraw(decimal withdrawAmount)
        {
            if (AccountBalance - withdrawAmount < MinimumBalance)
            {
                Console.WriteLine("You do not have enough money in the account to withdraw this amount. You must have a minimum balance of ${0}.", MinimumBalance);
                return AccountBalance;
            }
            else
            {
                AccountBalance -= withdrawAmount;
                return AccountBalance;
            }
        }


    }
}
