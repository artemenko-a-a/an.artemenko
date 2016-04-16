using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //// -------------------Task 1 (Existance of the number in random array)
            //int[] array;
            //int array_size;
            //int A;
            //Random rand = new Random();

            //Console.WriteLine("Enter the array size: ");
            //array_size = Convert.ToInt32(Console.ReadLine());

            //array = new int[array_size];

            //for (int i = 0; i < array_size; i++)
            //{
            //    array[i] = rand.Next(10);
            //}

            //for (int i = 0; i < array_size; i++)
            //{
            //    Console.Write(array[i] + " ");
            //}

            //Console.WriteLine("\nEnter number, which you want to check: ");
            //A = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Is this number in the array?");

            //if (Array.IndexOf(array, A) >= 0)
            //{ Console.WriteLine("Yes"); }
            //else { Console.WriteLine("No"); }

            //// -------------------------Task 2 (Revert sorting array consist of minimal values of each row of users NxM array)
            //int[][] users_matrix;
            //int[] result_array;
            //int number_of_rows;
            //int number_of_columns;
            //Random rand = new Random();

            //Console.Write("Enter number of rows: ");
            //number_of_rows = Convert.ToInt32(Console.ReadLine());
            //Console.Write("\nEnter number of columns: ");
            //number_of_columns = Convert.ToInt32(Console.ReadLine());

            //users_matrix = new int[number_of_rows][];
            //result_array = new int[number_of_rows];
            //for (int i = 0; i < number_of_rows; i++)
            //{
            //    users_matrix[i] = new int[number_of_columns];
            //}

            //for (int i = 0; i < number_of_rows; i++)
            //{
            //    int min = 0;
            //    for (int j = 0; j < number_of_columns; j++)
            //    {
            //        users_matrix[i][j] = rand.Next(10);
            //        Console.Write(users_matrix[i][j] + " ");
            //        if (j == 0) // first element of the row use as minimal
            //        {
            //            min = users_matrix[i][j];
            //        }
            //        if (users_matrix[i][j] < min) // compare all other elements of the row with min
            //        {
            //            min = users_matrix[i][j];
            //        }
            //    }
            //    result_array[i] = min; // writing minimal element of the row to the result array
            //    Console.WriteLine();
            //}

            //Array.Sort(result_array);
            //Console.WriteLine("Result array:");
            //for (int i = number_of_rows - 1; i >= 0; i--)
            //{
            //    Console.Write(result_array[i] + " ");
            //}
            //Console.WriteLine();

            // -----------------------------------Task 3 (Calculator)
            char[] input_string;
            string example;
            double operand_1 = 0;
            double operand_2 = 0;
            char operation = ' ';
            char[] available_operations = { '+', '-', '*', '/', '^'};

            double result = 0;
            string tmp = "";
            bool second = false;

            Console.WriteLine("Calculator");
            Console.WriteLine("Enter your example like \"x+y\" and press Enter");
            Console.WriteLine("Available operations: +,-,*,/,^");

            example = Console.ReadLine();
            input_string = new char[example.Length];
            input_string = example.ToCharArray();

            for (int i = 0; i < example.Length; i++)
            {
                if (!available_operations.Contains(input_string[i]))
                {
                    tmp += input_string[i];
                }
                else if (!second)
                {
                    operand_1 = Convert.ToDouble(tmp);
                    tmp = "";
                    second = true;
                    operation = input_string[i];
                }
            }
            operand_2 = Convert.ToDouble(tmp);
            if (operation == '+')
            {
                result = operand_1 + operand_2;
            }
            else if (operation == '-')
            {
                result = operand_1 - operand_2;
            }
            else if (operation == '*')
            {
                if (operand_1 == 0 | operand_2 == 0)
                {
                    result = 0;
                }
                else
                {
                    result = operand_1 * operand_2;
                }
            }
            else if (operation == '/')
            {
                if (operand_2 == 0)
                {
                    Console.WriteLine("Error! You can't divide on 0.");
                }
                else
                {
                    result = operand_1 / operand_2;
                }
            }
            else if (operation == '^')
            {
                result = 1;
                if (operand_2 == 0)
                {
                    result = 1;
                }
                else
                {
                    for (int i = 0; i < operand_2; i++)
                    {
                        result *= operand_1;
                    }
                }
            }
            Console.WriteLine(result);
        }

    }
}
