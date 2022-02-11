using System;
using System.Collections.Generic;
using System.Text;

//author:maria ali
namespace BankApplication
{
     /// <summary>
     /// create account class to send outputs and get inouts from user
     /// </summary>
     class Account
     {
          private double balance = 2000000; //set amount in acc as 2 mill, random
          public double balanceNow
          {
               get { return balance; }
               set { balance = value; }
          }
          //set variables
          public string name;
          public double account, inAccount;
          public double withdraw, deposit , total;
          
          //public function for credit account, outputs and calculates total in bank acc
          public void credit()
          {
               Console.WriteLine("Enter the name associated with this account: ");
               name = Console.ReadLine();
               Console.WriteLine("Enter your account number  :");
               account = Convert.ToInt32(Console.ReadLine());
               Console.WriteLine("Enter amount in credit: ");
               deposit = Convert.ToDouble(Console.ReadLine());
               total = balanceNow + deposit;
               //output to user
               Console.WriteLine("_________________________________________\n");
               Console.WriteLine("Enter the name associated with this account: " + name);
               Console.WriteLine("Account Number: " + account);
               Console.WriteLine("Total Balance: " + total);

          }

          //public function for debit account, outputs to user and creates withdrawl, then calculates total inn account after withdrawl
          public void debit()
          {
               Console.WriteLine("Enter the name associated with this account: ");
               name = Console.ReadLine();
               Console.WriteLine("Enter your account number: ");
               account = Convert.ToInt32(Console.ReadLine());
               Console.WriteLine("Enter the amount you would like to withdraw: ");
               withdraw = Convert.ToDouble(Console.ReadLine());
               if (withdraw <= balanceNow)
               {
                    total = balanceNow - withdraw;
                    Console.WriteLine("_________________________________________\n");
                    Console.WriteLine("Account Name: " + name);
                    Console.WriteLine("Account Number: " + account);
                    Console.WriteLine("New Balance: " + total);
               }
               else
                    Console.WriteLine("\n\nYour account does not have enough to withdraw the requested ammount.");
          }

     }
}
