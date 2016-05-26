using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask5
{
    class AccumulativeAccount : Account
    {
        private double _interestRate;
        private double _firstPay;

        public AccumulativeAccount(double interestRate, string accountNumber, string accountOwner, double accountStartSum) :
            base(accountNumber, accountOwner, accountStartSum)
        {
            if (interestRate < 0)
            {
				throw new ArgumentOutOfRangeException("Процентная ставка не может быть отрицательной");
			}
			_interestRate = interestRate;
            _firstPay = accountStartSum;
        }

        public static AccumulativeAccount CreateAccount(double interestRate, string accountNumber, string accountOwner, double startSum)
        {
			AccumulativeAccount accumulativeAccount = new AccumulativeAccount(interestRate, accountNumber, accountOwner, startSum);
			return accumulativeAccount;
        }

        public override void Withdraw(double sum)
        {
            if ( CurrentSum - sum < _firstPay)
            {
				throw new ArgumentOutOfRangeException ("На счету не может оставать меньше, чем " + _firstPay);
            }
            base.Withdraw(sum);
        }

        public double InterestRate
        {
            get { return _interestRate; }
        }

        public void Capitalize()
        {
            AddFunds(CurrentSum * _interestRate);
        }
    }
}
