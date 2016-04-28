using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask4
{
    class Program
    {
        static void Main(string[] args)
        {
            string usersTelephoneNumber;
            string usersCityCode;

            Console.WriteLine("Enter your city code:");
            usersCityCode = Console.ReadLine();
            Console.WriteLine("Enter your telephone number:");
            usersTelephoneNumber = Console.ReadLine();

            Telephone usersTelephone = new Telephone(usersTelephoneNumber);
            Console.WriteLine("Only number:");
            Console.WriteLine(usersTelephone.GetTelephoneNumber());

            Telephone usersTelephoneWithCityCode = new Telephone(usersCityCode, usersTelephoneNumber);
            Console.WriteLine("Number with city code:");
            Console.WriteLine(usersTelephoneWithCityCode.GetTelephoneNumber());

        }

        //// Task 1. Task from the lesson.
        //public class Telephone
        //{
        //    public readonly string CityCode;
        //    public readonly string TelephoneNumber;

        //    public Telephone(string code, string number)
        //    {
        //        CityCode = code;
        //        TelephoneNumber = number;
        //    }

        //    public Telephone(string number)
        //    {
        //        TelephoneNumber = number;
        //    }

        //    public string GetTelephoneNumber()
        //    {
        //        if (CityCode != null)
        //        {
        //            return "(" + CityCode + ") " + TelephoneNumber;
        //        }
        //        else
        //        {
        //            return TelephoneNumber;
        //        }
        //    }
        //}

        // Task 2. Class with properties.
        public class Telephone
        {
            private readonly string _cityCode;
            private readonly string _telephoneNumber;

            public Telephone(string code, string number)
            {
                _cityCode = code;
                _telephoneNumber = number;
            }

            public Telephone(string number)
            {
                _telephoneNumber = number;
            }

            public string CityCode
            {
                get { return _cityCode; }
            }

            public string TelephoneNumber
            {
                get { return _telephoneNumber; }
            }

            public string GetTelephoneNumber()
            {
                if (CityCode != null)
                {
                    return "(" + CityCode + ") " + TelephoneNumber;
                }
                else
                {
                    return TelephoneNumber;
                }
            }

        }

    }
}