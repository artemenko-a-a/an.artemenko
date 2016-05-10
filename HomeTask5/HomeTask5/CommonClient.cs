using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask5
{
    class CommonClient : Client
    {
        public CommonClient(string fio, List<Account> accounts) : base(fio, accounts) {}

        public override void AddAccount(Account clientsAccount)
        {
            if (AccountsCount <= 2)
            {
                base.AddAccount(clientsAccount);
            }
            else
                Console.WriteLine("You've reached the limit of accounts");
        }

        public override void CreateSavingAccount(string accountNumber, double startSum)
        {
            if (AccountsCount <= 2)
            {
                base.CreateSavingAccount(accountNumber, startSum);
            }
            else
                Console.WriteLine("You've reached the limit of accounts");
        }

        public override void CreateAccumulativeAccount(double interestRate, string accountNumber, double startSum)
        {
            if (AccountsCount <= 2)
            {
                base.CreateAccumulativeAccount(interestRate, accountNumber, startSum);
            }
            else
                Console.WriteLine("You've reached the limit of accounts");
        }

        public override void CreateCheckingAccount(double subscriptionFee, string accountNumber, double startSum)
        {
            if (AccountsCount <= 2)
            {
                base.CreateCheckingAccount(subscriptionFee, accountNumber, startSum);
            }
            else
                Console.WriteLine("You've reached the limit of accounts");
        }

        public override void CreateMetalAccount(double metalCourse, string accountNumber, double startSum)
        {
            if (AccountsCount <= 2)
            {
                base.CreateMetalAccount(metalCourse, accountNumber, startSum);
            }
            else
                Console.WriteLine("You've reached the limit of accounts");
        }

    }
}
