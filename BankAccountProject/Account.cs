﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProject
{
    abstract class Account
    {
 //This is the base class; must include:
 //An account number
 //Balance
 //An account type(savings or checking)
 //A way to view the current balance
 //User must be able to deposit money into either account
 //User must be able to withdraw money from either account

     //PROPERTIES
     public int AccountNumber { get; set; }
     public decimal AccountBalance { get; set; }

    //CONSTRUCTOR
    public Account()
        {

        }

     //METHODS
     public abstract decimal Deposit(decimal depositAmount);
                
        
     public virtual decimal Withdraw(decimal withdrawAmount)
        {
            return AccountBalance;
        }

     public void ViewBalance()
        {
            Console.WriteLine("The balance in the account is " + AccountBalance + ".");
        }



    }
}
