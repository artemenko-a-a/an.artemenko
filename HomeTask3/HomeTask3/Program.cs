using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask3
{
    class Program
    {
        static void Main(string[] args)
        {
            //// Task 1. 
            //Dictionary<char, int> usersDictionary = new Dictionary<char, int>();
            //string usersString;

            //Console.WriteLine("Enter some string:");
            //usersString = Console.ReadLine();

            //for (int i = 0; i < usersString.Length; i++)
            //{
            //    AddToDictionary(usersDictionary, GetCharFromString(usersString, i));
            //}

            //Console.WriteLine("Result dictionary:");
            //WriteDictionary(usersDictionary);

            // Task 2.
            HashSet<int> numbers = new HashSet<int>();
            HashSet<int> duplicateNumbers = new HashSet<int>();
            int currentNumber;

            Console.WriteLine("Enter some integers (-1 to stop)");
            while (true)
            {
                currentNumber = ReadInt();
                if (currentNumber != -1)
                {
                    if (!numbers.Contains(currentNumber))
                    {
                        numbers.Add(currentNumber);
                    }
                    else
                    {
                        duplicateNumbers.Add(currentNumber);
                    }
                }
                else
                {
                    break;
                }
            }

            if (duplicateNumbers.Any())
            {
                Console.WriteLine("There are all duplicate integers:");
                DisplaySet(duplicateNumbers);
            }
            else
            {
                Console.WriteLine("There is no duplicate integers");
            }




        }

        public static void AddToDictionary(Dictionary<char, int> someDictionary, char someChar)
        {
            int numberOfSuchKeys = 1;
            if (!someDictionary.ContainsKey(someChar))
            {
                someDictionary.Add(someChar, 1);
            }
            else
            {
                someDictionary.TryGetValue(someChar, out numberOfSuchKeys);
                someDictionary[someChar] = ++numberOfSuchKeys;
            }
        }

        public static void WriteDictionary(Dictionary<char, int> someDictionary)
        {
            foreach (KeyValuePair<char, int> kvp in someDictionary)
            {
                Console.WriteLine("Key = {0}, Value = {1}",
                    kvp.Key, kvp.Value);
            }
        }
        
        public static char GetCharFromString(string someString, int index)
        {
            if (index < someString.Length)
            {
                return Convert.ToChar(someString[index]);
            }
            else
            {
                return Convert.ToChar(someString[index % someString.Length]);
            }
        }

        public static int ReadInt()
        {
            return Convert.ToInt32(Console.ReadLine());
        }

        public static void DisplaySet(HashSet<int> set)
        {
            foreach (int i in set)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

    }
}
