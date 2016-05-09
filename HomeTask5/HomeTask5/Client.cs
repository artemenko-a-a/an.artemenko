using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask5
{
    class Client
    {
        private double _totalSum;
        private string _fio;
        private List<Account> _accounts = new List<Account>();

        public Client(string fio, List<Account> accounts)
        {
            _fio = fio;
            _accounts = accounts;
        }

        public double TotalSum
        {
            get
            {
                foreach (var account in _accounts)
                {
                    _totalSum += account.CurrentSum;
                }
                return _totalSum;
            }
        }

        public string FIO
        {
            get { return _fio; }
        }
    }
}
