using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
     class Program
     {
          /// <summary>
          /// create main output for account, create the menu to ask for user input
          /// </summary>
          /// <param name="args"></param>
          static void Main(string[] args)
          {
               char input; //user input

               //do while loop for main menu and user input
               do
               {
                    //main menu
                    CheckingAccount i = new CheckingAccount();
                    int num;
                    Console.WriteLine("Main Menu\n");
                    Console.WriteLine("_________________________________________\n");
                    Console.WriteLine("Enter 1 for credit balance. \n");
                    Console.WriteLine("Enter 2 for debit balance.");
                    num = Convert.ToInt32(Console.ReadLine());

                    //switch case for credit or debit account
                    switch (num)
                    {
                         case 1:
                              i.credit();
                              i.findInterest();
                              break;
                         case 2:
                              i.debit();
                              i.fee();
                              break;
                         default:
                              Console.WriteLine("This is not an option. Please try again.");
                              break;
                    }

                    // loop to continue if user would like
                    Console.WriteLine("\nPlease enter 'y' if you would like to continue, else enter any key.");
                    input = Convert.ToChar(Console.ReadLine());
               }
               while (input == 'y');
               Console.ReadKey();
          }
     }
  }

