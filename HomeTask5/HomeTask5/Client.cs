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
            if (accounts == null)
            {
                List<Account> emptyList = new List<Account>();
                _accounts = emptyList;
            }
            else
            {
                _accounts = accounts;
            }
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

        public Account GetAccount(string accountNumber)
        {
            foreach (var account in _accounts)
            {
                if (account.Number == accountNumber)
                {
                    return account;
                }
                else
                {
                    continue;
                }
            }
            return null;
        }

        public int AccountsNumber
        {
            get { return _accounts.Count; }
        }

        public string FIO
        {
            get { return _fio; }
        }

        virtual public void CreateAccount(string accountNumber, string accountType, double startSum)
        {
            switch (accountType)
            {
                case "Saving" :
                    Account savingAccount = new Account(accountNumber, _fio, startSum);
                    _accounts.Add(savingAccount);
                    break;
                case "Accumulative":
                    Console.WriteLine("You're trying to create Accumulative Account, please enter interest rate to continue: ");
                    double interestRate = Convert.ToDouble(Console.ReadLine());
                    AccumulativeAccount accumulativeAccount = new AccumulativeAccount(interestRate, accountNumber, _fio, startSum);
                    _accounts.Add(accumulativeAccount);
                    break;
                case "Checking":
                    Console.WriteLine("You're trying to create Checking Account, please enter subcsription fee to continue: ");
                    double subscriptionFee = Convert.ToDouble(Console.ReadLine());
                    CheckingAccount checkingAccount = new CheckingAccount(subscriptionFee, accountNumber, _fio, startSum);
                    _accounts.Add(checkingAccount);
                    break;
                case "Metal":
                    Console.WriteLine("You're trying to create Metal Account, please enter metal course to continue: ");
                    double metalCourse = Convert.ToDouble(Console.ReadLine());
                    MetalAccount metalAccount = new MetalAccount(metalCourse, accountNumber, _fio, startSum);
                    _accounts.Add(metalAccount);
                    break;
                default:
                    Console.WriteLine("There is no such account type.");
                    break;
            }
            
        }

        virtual public void AddAccount(Account clientsAccount)
        {
            _accounts.Add(clientsAccount);
        }

        public void CloseAccount(string accountNumber)
        {
            foreach (var account in _accounts)
            {
                if (account.Number == accountNumber)
                {
                    account.Close();
                }
                else
                    continue; 
            }
        }

        public double ShowFundsOnAccount(string clientsAccountNumber)
        {
            foreach (var account in _accounts)
            {
                if (account.Number == clientsAccountNumber)
                {
                    return account.CurrentSum;
                }
                else
                    continue; 
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
