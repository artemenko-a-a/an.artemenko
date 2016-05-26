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
			try
			{
				firstAccount.Withdraw(sum);
			}
			catch (InvalidOperationException ex)
			{
				Console.WriteLine(ex.Message);
			}
			catch (ArgumentOutOfRangeException ex)
			{
				Console.WriteLine(ex.Message);
			}
			try
			{
				secondAccount.AddFunds(sum);
			}
			catch (InvalidOperationException ex)
			{
				Console.WriteLine(ex.Message);
				firstAccount.AddFunds(sum);
			}
			catch (ArgumentOutOfRangeException ex)
			{
				Console.WriteLine(ex.Message);
				firstAccount.AddFunds(sum);
			}
        }
    }
}
