using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime petrovBirthDate = new DateTime(1993, 2, 1);

            IP Petrov = new IP("Петров Иван Сидорович", petrovBirthDate, "0001", "3516411");
            OOO Sidorov = new OOO("Сидоров Александр Викторович", "s123b875", "0002", "383383");

            ShowIpInfo(Petrov);
            ShowOOOInfo(Sidorov);
            
            Sidorov.AddToSumm(1000);
            Petrov.AddToSumm(100);

            ShowIpInfo(Petrov);
            ShowOOOInfo(Sidorov);

            Sidorov.SubSumm(800);
            ShowOOOInfo(Sidorov);

        }

        public static void ShowIpInfo(IP ip)
        {
            Console.WriteLine("IP information:");
            Console.WriteLine("Name: " + ip.FIO);
            Console.WriteLine("Telephone: " + ip.Telephone);
            Console.WriteLine("ID: " + ip.Id);
            Console.WriteLine("Summ: " + ip.Summ + "\n");
        }

        public static void ShowOOOInfo(OOO ooo)
        {
            Console.WriteLine("OOO information:");
            Console.WriteLine("Name: " + ooo.Name);
            Console.WriteLine("Telephone: " + ooo.Telephone);
            Console.WriteLine("ID: " + ooo.Id);
            Console.WriteLine("Bill Number: " + ooo.BillNumber);
            Console.WriteLine("Summ: " + ooo.Summ + "\n");
        }

        public class Client
        {
            private string _id;
            private string _telephone;
            private double _summ;

            public Client(string id, string telephone, double summ = 0.0)
            {
                _id = id;
                _telephone = telephone;
                _summ = summ;
            }

            public string Id
            {
                get { return _id; }
            }

            public string Telephone
            {
                get { return _telephone; }
            }

            public double Summ
            {
                get { return _summ; }
                set { _summ = value; }
            }

            public void AddToSumm(double newSumm)
            {
                Summ += newSumm;
            }

            public void SubSumm(double newSumm)
            {
                if (newSumm > Summ)
                {
                    Console.WriteLine("Summ shouldn't be less than 0");
                }
                else
                {
                    Summ -= newSumm;
                }
            }

            public string ClientsSumm()
            {
                if ((Summ % 1) != 0)
                {
                    return (Summ / 1).ToString() + " p." + (Summ % 1).ToString() + " к.";
                }
                else
                {
                    return (Summ / 1).ToString() + " р.";
                }
            }
        }

        public class IP : Client
        {
            private string _fio;
            private DateTime _birthDate;

            public IP(string fio, DateTime birthDate, string id, string telephone, double summ = 0.0) : base(id, telephone, summ)
            {
                _fio = fio;
                _birthDate = birthDate;
            }

            public string FIO
            {
                get { return _fio; }
            }

            public DateTime BirthDate
            {
                get { return _birthDate; }
            }

            public string IPName()
            {
                return FIO + " " + base.ClientsSumm();
            }
        }

        public class OOO : Client
        {
            private string _name;
            private string _billNumber;

            public OOO(string name, string billNumber, string id, string telephone, double summ = 0.0): base(id, telephone, summ)
            {
                _name = name;
                _billNumber = billNumber;
            }

            public string Name
            {
                get { return _name; }
            }

            public string BillNumber
            {
                get { return _billNumber; }
            }

            public string OOOName()
            {
                return Name + " " + base.ClientsSumm();
            }
        }
    }
}
