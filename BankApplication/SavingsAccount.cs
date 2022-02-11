using System;
using System.Collections.Generic;
using System.Text;

namespace BankApplication
{
     /// <summary>
     /// class for saving account, referencing class account to calculate balance in savings. includes interest
     /// </summary>
     class SavingsAccount : Account
     {
          /// <summary>
          /// create variables for interest, interest rate, and calculate the total balance after adding interest 
          /// </summary>
          double interest, intRate;
          public void findInterest()
          {
               interest = 0.06; //setting a random interest rate
               //calculation of interest based on amount
               intRate = total * (interest / 100);
               inAccount = total + intRate; //find amount in balance after calculating rate
               Console.WriteLine("Total balance including interest: " + inAccount);
          }

     }
    
}
