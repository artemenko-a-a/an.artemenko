﻿using System;namespace HomeTask7{	public struct Fraction : IComparable	{		public int X { get; private set;}		public int Y { get; private set;}		public Fraction(int x, int y)		{            if (y == 0)
            {
                throw new InvalidOperationException("Знаменатель не может равняться нулю");
            }            if (y < 0 || x < 0)
            {
                throw new ArgumentOutOfRangeException("Дробь не может быть отрицательной");
            }            int n = GetNOD(x, y);
            X = x / n;
            Y = y / n;		}		public override string ToString ()		{			return $"{X}/{Y}";		}		private static int GetNOD(int x, int y)		{            if (x != 0)
            {
                while (x != y)
                {
                    if (x > y)
                    {
                        if (x % y != 0)
                        {
                            x = x % y;
                        }
                        else
                        {
                            x = y;
                        }
                    }
                    else
                    {
                        if (y % x != 0)
                        {
                            y = y % x;
                        }
                        else
                        {
                            y = x;
                        }
                    }
                }
                return x;
            }
            return 1;		}		public Fraction Sum(Fraction someFraction)		{			int newX;			int newY;			if (Y != someFraction.Y)			{				newX = X * someFraction.Y + someFraction.X * Y;				newY = Y * someFraction.Y;			}			else			{				newX = X + someFraction.X;				newY = Y;			}			return new Fraction (newX, newY);		}		public Fraction Sub(Fraction someFraction)		{			int newX;			int newY;			if (Y != someFraction.Y)			{				if (X * someFraction.Y < someFraction.X * Y)				{                    throw new InvalidOperationException("Нельзя выполнить вычитание, поскольку первая дробь меньше второй.");
                }
                newX = X * someFraction.Y - someFraction.X * Y;
                newY = Y * someFraction.Y;			}			else			{				if (X < someFraction.X)				{                    throw new InvalidOperationException("Нельзя выполнить вычитание, поскольку первая дробь меньше второй.");				}                newX = X - someFraction.X;
                newY = Y;			}			return new Fraction (newX, newY);		}		public Fraction Mul(Fraction someFraction)		{			return new Fraction (X * someFraction.X, Y * someFraction.Y);		}		public Fraction Div(Fraction someFraction)		{			int newX;			int newY;			if (someFraction.X == 0)			{                throw new ArgumentOutOfRangeException("Нельзя делить на ноль.");			}            newX = X * someFraction.Y;
            newY = Y * someFraction.X;			return new Fraction (newX, newY);		}		public int CompareTo (object obj)		{			Fraction someFraction = (Fraction)obj;			if (Y != someFraction.Y)			{				if (X * someFraction.Y > someFraction.X * Y)				{					return 1;				}				if (X * someFraction.Y < someFraction.X * Y)				{					return -1;				}				return 0;			}			if (X > someFraction.X)			{				return 1;			}			if (X < someFraction.X)			{				return -1;			}			return 0;		}	}}