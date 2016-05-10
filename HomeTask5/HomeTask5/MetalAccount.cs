using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask5
{
    class MetalAccount : Account
    {
        private double _metalWeight = 0;
        private double _metalCourse;


        public MetalAccount(double metalCourse, string accountNumber, string accountOwner, double accountStartSum) :
            base(accountNumber, accountOwner, accountStartSum)
        {
            _metalCourse = metalCourse;
            _metalWeight = accountStartSum / _metalCourse;
        }

        public double MetalWeight
        {
            get { return _metalWeight; }
        }

        public override double CurrentSum
        {
            get { return _metalWeight * _metalCourse; }
        }

        public override bool AddFunds(double sum)
        {
            if (Open)
            {
                if (sum > 0)
                {
                    _metalWeight += sum / _metalWeight;
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

        public override bool Withdraw(double sum)
        {
            if (Open)
            {
                if (sum / _metalCourse <= _metalWeight)
                {
                    _metalWeight -= sum / _metalCourse;
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
    }
}
