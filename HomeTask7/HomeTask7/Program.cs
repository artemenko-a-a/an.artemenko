using System;namespace HomeTask7{	class MainClass	{		public static void Main (string[] args)		{			int n;			Fraction sum = new Fraction (0, 1);			Random rand = new Random();			Console.WriteLine ("Введите количество дробей для генерации: ");			n = Convert.ToInt32 (Console.ReadLine ());			Fraction[] fractionArray = new Fraction[n];			for (int i = 0; i < n; i++)			{                try
                {
                    fractionArray[i] = new Fraction(rand.Next(5), rand.Next(10));
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine("Генерация дроби завершилась с ошибкой. " + ex.Message);
                    i--;
                }                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine("Генерация дроби завершилась с ошибкой. " + ex.Message);
                    i--;
                }
            }			for (int i = 0; i < fractionArray.Length; i++)			{				Console.WriteLine (fractionArray[i]);			}			for (int i = 0; i < fractionArray.Length; i++)			{				sum = sum.Sum (fractionArray [i]);			}			Console.WriteLine ("Сумма всех дробей массива равна: {0}", sum);		}	}}