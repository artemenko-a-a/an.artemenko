using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray;
            double[] doubleArray;
            int arraySize;
            string usersChoice;

            System.Console.WriteLine("Enter array size");
            arraySize = ReadInt();
            intArray = new int[arraySize];
            doubleArray = new double[arraySize];

            System.Console.WriteLine("Enter array of int");
            for (int i = 0; i < arraySize; i++)
            {
                intArray[i] = ReadInt();
            }
            System.Console.WriteLine("Enter array of double");
            for (int i = 0; i < arraySize; i++)
            {
                doubleArray[i] = ReadDouble();
            }

            System.Console.WriteLine("Choose what kind of array do you want to see (int or double)");
            usersChoice = Console.ReadLine();
            if (usersChoice.Equals("int"))
            {
                WriteArray(intArray);
            }
            else if (usersChoice.Equals("double"))
            {
                WriteArray(doubleArray);
            }
        }

        public static int ReadInt()
        {
            return Convert.ToInt32(Console.ReadLine());
        }

        public static double ReadDouble()
        {
            return Convert.ToDouble(Console.ReadLine());
        }

        public static void WriteNumber(int x)
        {
            Console.WriteLine(x);
        }

        public static void WriteNumber(double x)
        {
            Console.WriteLine(x);
        }

        public static void WriteArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }

        public static void WriteArray(double[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
