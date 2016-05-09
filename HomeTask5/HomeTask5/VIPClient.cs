using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask5
{
    class VIPClient : Client
    {
        public VIPClient(string fio, List<Account> accounts) : base(fio, accounts) {}

        public override void AddAccount(Account clientsAccount)
        {
            if (AccountsNumber <= 9)
            {
                base.AddAccount(clientsAccount);
            }
            else
                Console.WriteLine("You've reached the limit of accounts");
            
        }
    }
}
