using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask5
{
    class Bank
    {
        public void Transfer(Account firstAccount, Account secondAccount, double sum)
        {
            if (firstAccount.Open)
            {
                if (secondAccount.Open)
                {
                    if (firstAccount.Withdraw(sum))
                    {
                        secondAccount.AddFunds(sum);
                    }
                    else
                    {
                        Console.WriteLine("There is not enough funds on the first account");
                    }
                }
                else
                {
                    Console.WriteLine("Second account is closed. You can't transfer any funds to it.");
                }
            }
            else
            {
                Console.WriteLine("First account is closed. You can't transfer any funds from it.");
            }
        }
    }
}
