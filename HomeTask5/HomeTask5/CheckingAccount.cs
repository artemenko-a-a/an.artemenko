using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask5
{
    class CheckingAccount : Account
    {
        private double _subscriptionFee;

        public CheckingAccount(double subscriptionFee, string accountNumber, string accountOwner, double accountStartSum) :
            base(accountNumber, accountOwner, accountStartSum)
        {
            if (subscriptionFee >= 0)
            {
                _subscriptionFee = subscriptionFee;
            }
            else
            {
                Console.WriteLine("You can't create Checking Account without subscription fee");
            }
        }

        public static CheckingAccount CreateAccount(double subscriptionFee, string accountNumber, string accountOwner, double startSum)
        {
            CheckingAccount checkingAccount = new CheckingAccount(subscriptionFee, accountNumber, accountOwner, startSum);
            return checkingAccount;
        }

        public double SubscriptionFee
        {
            get { return _subscriptionFee; }
        }

        public void SubscriptionWithdraw()
        {
            if (CurrentSum < _subscriptionFee)
            {
                Console.WriteLine("There is not enough funds for subscription fee");
            }
            else
            {
                Withdraw(_subscriptionFee);
            }
        }
    }
}
