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

        virtual public void AddFunds(double sum)
        {
            if (_open)
            {
                if (sum >= 0)
                {
                    _currentSum += sum;
                }
                else
                {
                    Console.WriteLine("You can't add negative sum");
                }
            }
            else
            {
                Console.WriteLine("Account is closed");
            }
        }

        virtual public void Withdraw(double sum)
        {
            if (_open)
            {
                if (sum <= _currentSum)
                {
                    _currentSum -= sum;
                }
                else
                {
                    Console.WriteLine("You don't have enough funds");
                }
            }
            else
            {
                Console.WriteLine("Account is closed");
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
