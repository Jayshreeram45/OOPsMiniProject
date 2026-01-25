using System;
using System.Collections.Generic;
using System.Text;

namespace OOPsMiniProject
{
    internal class BankAccount
    {
        long AccountNo;
        String HolderName = "";
        Decimal Balance;

        internal void Deposit(int Amount)
        {
            Balance += Amount;
            Console.WriteLine("Amount Deposited in the bank");
        }
        internal void Withdraw(int Amount)
        {
            Balance -= Amount;
            if (Balance < 500)
                Console.WriteLine("Balance Never Be Below 500");
            else
            {
                Console.WriteLine("After Withdraw Amount From Bank remaining Balance in my bank Account");
                Console.WriteLine(Balance);
            }
        }

    }
}
