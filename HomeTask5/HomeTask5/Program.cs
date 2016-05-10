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
            //Account ivanov = new Account("0001", "иванов иван иванович", 1000);
            //AccumulativeAccount petrov = new AccumulativeAccount(1, "0002", "петров петр петрович", 100);
            //CheckingAccount ganchin = new CheckingAccount(50, "0003", "ганчин алексей федотович", 125);
            //MetalAccount semenov = new MetalAccount(25, "0004", "семенов семен борисович", 100);
            //ivanov.Withdraw(800);
            //petrov.Capitalize();
            //ganchin.SubscriptionWithdraw();
            //semenov.Withdraw(50);

            //Console.WriteLine(ivanov.Owner + " " + ivanov.CurrentSum);
            //Console.WriteLine(petrov.Owner + " " + petrov.CurrentSum);
            //Console.WriteLine(ganchin.Owner + " " + ganchin.CurrentSum);
            //Console.WriteLine(semenov.Owner + " " + semenov.CurrentSum + " " + semenov.MetalWeight);


            CommonClient Petrov = new CommonClient("Petrov Petr Petrovich", null);
            VIPClient Smirnov = new VIPClient("Smirnov Ivan Aleksandrovich", null);
            Petrov.AddAccount(MetalAccount.CreateAccount(30, "001", Petrov.FIO, 900));
            Smirnov.AddAccount(CheckingAccount.CreateAccount(10, "002", Smirnov.FIO, 1000));
            Bank Bank = new Bank();
            Bank.Transfer(Smirnov.GetAccount("002"), Petrov.GetAccount("001"), 100);
            Petrov.ShowAllAccounts();
            Smirnov.ShowAllAccounts();

            

            //List<Account> accounts = new List<Account>();

            //AccumulativeAccount account1 = new AccumulativeAccount(0.1, "0001", "Иванов Иван Иванович", 1000);
            //CheckingAccount account2 = new CheckingAccount(50, "0002", "Иванов Иван Иванович", 2000);
            //MetalAccount account3 = new MetalAccount(25, "0003", "Иванов Иван Иванович", 1500);

            //accounts.Add(account1);
            //accounts.Add(account2);
            //accounts.Add(account3);

            //Console.WriteLine("Account1 " + account1.CurrentSum);
            //Console.WriteLine("Account2 " + account2.CurrentSum);
            //Console.WriteLine("Account3 " + account3.CurrentSum);
            //Client User = new Client("Петров", accounts);
            //Console.WriteLine("Total " + User.TotalSum);


        }

    }
}
