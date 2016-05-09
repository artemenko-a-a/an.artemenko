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
            if (interestRate >= 0)
            {
                _interestRate = interestRate;
            }
            else
            {
                Console.WriteLine("You can't create Savings Account without interest rate");
            }
            _firstPay = accountStartSum;
        }
        public override bool AddFunds(double sum)
        {
            if (sum < 0)
            {
                Console.WriteLine("You can't add negative funds");
                return false;
            }
            else
            {
                base.AddFunds(sum);
                return true;
            }
        }

        public override bool Withdraw(double sum)
        {
            if ( CurrentSum - sum < _firstPay)
            {
                Console.WriteLine("You can't leave less, than " + _firstPay);
                return false;
            }
            else
            {
                base.Withdraw(sum);
                return true;
            }
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
