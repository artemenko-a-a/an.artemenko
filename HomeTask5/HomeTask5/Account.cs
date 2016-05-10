using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask5
{
    class Account
    {
        private double _currentSum;
        private bool _open;

        public string Number { get; set; }
        public string Owner { get; set; }

        virtual public double CurrentSum
        {
            get { return _currentSum; }
        }

        public bool Open
        {
            get { return _open; }
        }

        public Account(string accountNumber, string accountOwner, double accountStartSum)
        {
            Number = accountNumber;
            Owner = accountOwner;
            if (accountStartSum >= 0)
            {
                _currentSum = accountStartSum;
            }
            else
            {
                Console.WriteLine("You can't create account without funds");
            }
            _open = true;
        }

        virtual public bool AddFunds(double sum)
        {
            if (_open)
            {
                if (sum >= 0)
                {
                    _currentSum += sum;
                    return true;
                }
                else
                {
                    Console.WriteLine("You can't add negative sum");
                    return false;
                }
            }
            else
            {
                Console.WriteLine("Account is closed");
                return false;
            }
        }

        virtual public bool Withdraw(double sum)
        {
            if (_open)
            {
                if (sum <= _currentSum)
                {
                    _currentSum -= sum;
                    return true;
                }
                else
                {
                    Console.WriteLine("You don't have enough funds");
                    return false;
                }
            }
            else
            {
                Console.WriteLine("Account is closed");
                return false;
            }
        }

        public void Close()
        {
            if (CurrentSum == 0)
            {
                _open = false;
            }
            else
            {
                Console.WriteLine("You can't close the account with any funds on it");
            }
        }
    }
}
