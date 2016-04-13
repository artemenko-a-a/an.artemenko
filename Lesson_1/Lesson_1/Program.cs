using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // --summ of 2 integers
            //int var1;
            //int var2;
            //int sum;
            //var1 = Convert.ToInt32(Console.ReadLine());
            //var2 = Convert.ToInt32(Console.ReadLine());
            //sum = var1 + var2;
            //Console.WriteLine(sum);

            // -- show i bit of n
            //int n;
            //int i;
            //int result;
            //int mask = 1;
            //n = Convert.ToInt32(Console.ReadLine());
            //i = Convert.ToInt32(Console.ReadLine());
            //result = (n >> (i - 1)) & mask;
            //Console.WriteLine(result);

            // -- lower bit to 0
            int n; // users number
            int result;
            int mask = 30; // mask with 0 on the lower bit
            n = Convert.ToInt32(Console.ReadLine());
            result = n & mask;
            Console.WriteLine(result);
        }
    }
}
