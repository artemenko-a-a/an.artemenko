using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //int n; // number of users numbers
            //int sum = 0;
            //int max = 0;
            //int min = 0;
            //int count_of_even = 0;
            //int mul_of_odd = 0;

            //n = Convert.ToInt32(Console.ReadLine());

            //for (int i = 0; i < n; i++)
            //{
            //    int current = Convert.ToInt32(Console.ReadLine());
            //    sum += current;

            //    if (current > max)
            //    {
            //        max = current;
            //    }

            //    if (i == 0)
            //    {
            //        min = current;
            //    }
            //    else if (current < min)
            //    {
            //        min = current;
            //    }

            //    if (current % 2 == 0)
            //    {
            //        count_of_even++;
            //    }
            //    else
            //    {
            //        if (mul_of_odd == 0)
            //        {
            //            mul_of_odd++;
            //        } 
            //        mul_of_odd *= current;
            //    }
            //}

            //Console.WriteLine(" sum of numbers: " + sum + "\n max number: " + max + "\n min number: " + 
            //    min + "\n count of even: " + count_of_even + "\n mul of odd: " + mul_of_odd);

            //----------------------------------------------
            //int[] user_values;
            //int size;

            //size = Convert.ToInt32(Console.ReadLine());
            //user_values = new int[size];

            //for (int i = 0; i < size; i++)
            //{
            //    user_values[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //Array.Sort(user_values);
            //for (int i = 0; i < size; i++)
            //{
            //    if (i < size - 1)
            //    {
            //        Console.Write(user_values[i] + ", ");
            //    }
            //    else
            //    { Console.Write(user_values[i] + "\n"); }
            //}

            //----------------------------------------------
            int[][] matrix1;
            int[][] matrix2;
            int[][] result_matrix;
            int side_length;
            Random random_number = new Random();

            side_length = Convert.ToInt32(Console.ReadLine());
            matrix1 = new int[side_length][];
            matrix2 = new int[side_length][];
            result_matrix = new int[side_length][];
            for (int i = 0; i < side_length; i++)
            {
                matrix1[i] = new int[side_length];
                matrix2[i] = new int[side_length];
                result_matrix[i] = new int[side_length];
            }

            // generating random matrix & calculating result matrix
            for (int i = 0; i < side_length; i++)
            {
                for (int j = 0; j < side_length; j++)
                {
                    matrix1[i][j] = random_number.Next(10);
                    matrix2[i][j] = random_number.Next(10);
                    result_matrix[i][j] = matrix1[i][j] + matrix2[i][j];
                }
            }
            // printing first matrix on the screen
            Console.WriteLine("\nFirst matrix");
            for (int i = 0; i < side_length; i++)
            {
                for (int j = 0; j < side_length; j++)
                {
                    Console.Write(matrix1[i][j] + " ");
                }
                Console.WriteLine();
            }
            // printing second matrix on the screen
            Console.WriteLine("\nSecond matrix");
            for (int i = 0; i < side_length; i++)
            {
                for (int j = 0; j < side_length; j++)
                {
                    Console.Write(matrix2[i][j] + " ");
                }
                Console.WriteLine();
            }

            // printing result matrix on the screen
            Console.WriteLine("\nResult matrix");
            for (int i = 0; i < side_length; i++)
            {
                for (int j = 0; j < side_length; j++)
                {
                    Console.Write(result_matrix[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
