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
            if (accountStartSum < 0)
            {
				throw new ArgumentOutOfRangeException ("Нельзя открыть счет с отрицательным балансом");
            }
			_currentSum = accountStartSum;
            _open = true;
        }

        public static Account CreateAccount(string accountNumber, string accountOwner, double accountStartSum)
        {
			Account savingsAccount = new Account(accountNumber, accountOwner, accountStartSum);
			return savingsAccount;
        }

        virtual public void AddFunds(double sum)
        {
            if (!_open)
            {
				throw new InvalidOperationException ("Операция невозможна, т.к. счет закрыт");
            }
			if (sum < 0)
			{
				throw new ArgumentOutOfRangeException ("Нельзя положить на счет отрицательную сумму");
			}
			_currentSum += sum;
        }

        virtual public void Withdraw(double sum)
        {
            if (!_open)
            {
				throw new InvalidOperationException ("Операция невозможна, т.к. счет закрыт");
            }
			if (sum > _currentSum)
			{
				throw new InvalidOperationException ("Остаток на счете не может быть меньше нуля");
			}
			_currentSum -= sum;
        }

        public void Close()
        {
            if (CurrentSum != 0)
            {
				throw new InvalidOperationException ("Операция невозможна, т.к. на счету есть средства");
            }
			if (_open == false)
			{
				throw new InvalidOperationException ("Аккаунт уже закрыт");
			}
			_open = false;
        }
    }
}
