using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask5
{
    abstract class Client
    {
        private double _totalSum;
        private string _fio;
        private List<Account> _accounts = new List<Account>();

        public Client(string fio, List<Account> accounts)
        {
            _fio = fio;
            if (accounts != null)
            {
                _accounts = accounts;
            }
        }

        public double TotalSum
        {
            get
            {
                _totalSum = 0;
                foreach (var account in _accounts)
                {
                    _totalSum += account.CurrentSum;
                }
                return _totalSum;
            }
        }

        public Account GetAccount(string accountNumber)
        {
            foreach (var account in _accounts)
            {
                if (account.Number == accountNumber)
                {
                    return account;
                }
            }
            return null;
        }

        public int AccountsCount
        {
            get { return _accounts.Count; }
        }

        public string FIO
        {
            get { return _fio; }
        }

        public virtual void AddAccount(Account clientsAccount)
        {
            _accounts.Add(clientsAccount);
        }

        public bool CloseAccount(string accountNumber)
        {
            foreach (var account in _accounts)
            {
                if (account.Number == accountNumber)
                {
                    if (account.Open)
                    {
                        account.Close();
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("Account is already closed.");
                        return false;
                    }
                }
            }
            Console.WriteLine("Client {0} doesn't have such account", _fio);
            return false;
        }

        public double ShowFundsOnAccount(string clientsAccountNumber)
        {
            foreach (var account in _accounts)
            {
                if (account.Number == clientsAccountNumber)
                {
                    return account.CurrentSum;
                } 
            }
            return 0;
        }

        public void ShowAllAccounts()
        {
            Console.WriteLine("All accounts, that belongs to {0} :", _fio);
            foreach (var account in _accounts)
            {
                Console.WriteLine("Account number: {0} Rest funds: {1}", account.Number, account.CurrentSum);
            }
        }
    }
}
