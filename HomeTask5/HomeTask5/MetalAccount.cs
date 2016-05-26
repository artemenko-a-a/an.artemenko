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

        public static MetalAccount CreateAccount(double metalCourse, string accountNumber, string accountOwner, double startSum)
        {
			MetalAccount metalAccount = new MetalAccount(metalCourse, accountNumber, accountOwner, startSum);
			return metalAccount;
        }

        public double MetalWeight
        {
            get { return _metalWeight; }
        }

        public override double CurrentSum
        {
            get { return _metalWeight * _metalCourse; }
        }

        public override void AddFunds(double sum)
        {
            if (!Open)
            {
				throw new InvalidOperationException ("Операция невозможна, т.к. счет закрыт");
            }
			if (sum < 0)
			{
				throw new ArgumentOutOfRangeException ("Нельзя положить на счет сумму меньше нуля");
			}
			_metalWeight += sum / _metalWeight;
        }

        public override void Withdraw(double sum)
        {
            if (!Open)
            {
				throw new InvalidOperationException ("Операция невозможна, т.к. счет закрыт");
			}
			if (sum / _metalCourse > _metalWeight)
			{
				throw new ArgumentOutOfRangeException ("На счету недостаточно средств");
			}
			_metalWeight -= sum / _metalCourse;
        }
    }
}
