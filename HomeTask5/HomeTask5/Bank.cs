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
            if (firstAccount.Withdraw(sum))
            {
                secondAccount.AddFunds(sum);
            }
            else
            {
                Console.WriteLine("There is not enough funds on the first account");
            }
        }
    }
}
