using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask5
{
    class Program
    {
        static void Main(string[] args)
        {
            CommonClient Petrov = new CommonClient("Petrov Petr Petrovich", null);
            VIPClient Smirnov = new VIPClient("Smirnov Ivan Aleksandrovich", null);
            Petrov.AddAccount(MetalAccount.CreateAccount(30, "001", Petrov.FIO, 100));
            Smirnov.AddAccount(CheckingAccount.CreateAccount(10, "002", Smirnov.FIO, 50));
            Bank Bank = new Bank();
            Bank.Transfer(Smirnov.GetAccount("002"), Petrov.GetAccount("001"), 100);

			try
			{
				Petrov.GetAccount("002").AddFunds(-2);
			}
			catch (NullReferenceException ex)
			{
				Console.WriteLine(ex.Message);
			}
			catch (ArgumentOutOfRangeException ex)
			{
				Console.WriteLine(ex.Message);
			}

        }
    }
}
