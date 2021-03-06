﻿using System;
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
				throw new InvalidOperationException("Данный клиент не может иметь больше счетов");
        }
    }
}
