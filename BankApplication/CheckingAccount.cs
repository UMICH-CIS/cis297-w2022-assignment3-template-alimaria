using System;
using System.Collections.Generic;
using System.Text;

namespace BankApplication
{
     /// <summary>
     /// class for checking account, transaction fee created as well as creating the updated balance after a deposit or withdrawl, references savings account class
     /// </summary>
     class CheckingAccount : SavingsAccount
     {
          //setting a random fee
          double transFee = 5;
          public void fee()
          {
               Console.WriteLine("Updated balance: " + (total - transFee));
          }
     }
}
