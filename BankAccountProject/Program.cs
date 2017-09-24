using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProject
{
    class Program
    {
        public static void ShowOptions()
        {
            Console.WriteLine("1. View Client Information");
            Console.WriteLine("2. View Account Balance");
            Console.WriteLine("3. Deposit Funds");
            Console.WriteLine("4. Withdraw Funds");
            Console.WriteLine("5. Exit");
        }

        static void Main(string[] args)
        {
            //Must instantiate one client object
            //Must instantiate one checking account object
            //Must instantiate one savings account object
            //All menu options listed above must have functionality behind them
            //Program should run until user selects 'Exit'

            //SWITCH CASE??

            Client firstClient = new Client();
            CheckingAccount firstChecking = new CheckingAccount(129304, 567.80m);
            SavingsAccount firstSavings = new SavingsAccount(129305, 100.00m, 10.00m);

            Console.WriteLine("Hello, {0}! Please select an option.", firstClient.FirstName);
            Console.WriteLine();
            bool isUsing = true;
            while (isUsing == true)
            {
                ShowOptions();
                int userChoice = int.Parse(Console.ReadLine());

               switch (userChoice)
                {
                    case 1:
                        {
                            Console.WriteLine("Name: {0} {1}", firstClient.FirstName, firstClient.LastName);
                            Console.WriteLine("Age: {0}", firstClient.Age);
                            Console.WriteLine();
                            break;
                        }

                    case 2:
                        {
                            Console.WriteLine();
                            bool choseOption = true;
                            while (choseOption == true)
                            {
                                Console.WriteLine("Which account would you like to view the balance of?");
                                Console.WriteLine("a. Checking Account");
                                Console.WriteLine("b. Savings Account");
                                string accountChoice = Console.ReadLine();
                                Console.WriteLine();
                                                                
                                if (accountChoice.Equals("a", StringComparison.CurrentCultureIgnoreCase))
                                {
                                    Console.WriteLine("Your checking account balance is ${0}", firstChecking.AccountBalance);
                                    choseOption = false;
                                }

                                else if (accountChoice.Equals("b", StringComparison.CurrentCultureIgnoreCase))
                                {
                                    Console.WriteLine("Your savings account balance is ${0}", firstSavings.AccountBalance);
                                    choseOption = false;
                                }

                                else
                                {
                                    Console.WriteLine("Please select 'a' or 'b'.");
                                }
                                Console.WriteLine();
                             }
                            break;
                        }

                    case 3:
                        {
                            Console.WriteLine();
                            Console.WriteLine("How much would you like to deposit?");
                            decimal depositAmount = decimal.Parse(Console.ReadLine());
                     
                            bool choseOption = true;
                            while (choseOption == true)
                            {
                                Console.WriteLine("Which account would you like to deposit into?");
                                Console.WriteLine("a. Checking Account");
                                Console.WriteLine("b. Savings Account");
                                string accountChoice = Console.ReadLine();
                                Console.WriteLine();

                                if (accountChoice.Equals("a", StringComparison.CurrentCultureIgnoreCase))
                                {
                                    firstChecking.Deposit(depositAmount);
                                    Console.WriteLine("Your checking account balance is now ${0}", firstChecking.AccountBalance);
                                    choseOption = false;
                                }

                                else if (accountChoice.Equals("b", StringComparison.CurrentCultureIgnoreCase))
                                {
                                    firstSavings.Deposit(depositAmount);
                                    Console.WriteLine("Your savings account balance is now ${0}", firstSavings.AccountBalance);
                                    choseOption = false;
                                }

                                else
                                {
                                    Console.WriteLine("Please select 'a' or 'b'.");
                                }
                                Console.WriteLine();
                            }
                            break;
                        }

                    case 4:
                        {
                            Console.WriteLine();
                            Console.WriteLine("How much would you like to withdraw?");
                            decimal withdrawAmount = decimal.Parse(Console.ReadLine());

                            bool choseOption = true;
                            while (choseOption == true)
                            {
                                Console.WriteLine("Which account would you like to withdraw from?");
                                Console.WriteLine("a. Checking Account");
                                Console.WriteLine("b. Savings Account");
                                string accountChoice = Console.ReadLine();
                                Console.WriteLine();

                                if (accountChoice.Equals("a", StringComparison.CurrentCultureIgnoreCase))
                                {
                                    firstChecking.Withdraw(withdrawAmount);
                                    Console.WriteLine("Your checking account balance is now ${0}.", firstChecking.AccountBalance);
                                    choseOption = false;
                                }

                                else if (accountChoice.Equals("b", StringComparison.CurrentCultureIgnoreCase))
                                {
                                    firstSavings.Withdraw(withdrawAmount);
                                    Console.WriteLine("Your savings account balance is now ${0}.", firstSavings.AccountBalance);
                                    choseOption = false;
                                }

                                else
                                {
                                    Console.WriteLine("Please select 'a' or 'b'.");
                                }
                                Console.WriteLine();
                            }

                            break;
                        }

                    case 5:
                        
                            isUsing = false;
                            break;
                        

                    default:
                        {
                            Console.WriteLine("That is not an option; please select one of the menu options.");
                        }
                        break;

                }
                
            }

            Console.WriteLine();
            Console.WriteLine("Thank you! See you next time.");
        }
    }
}
