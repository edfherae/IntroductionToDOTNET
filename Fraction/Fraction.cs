using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fraction
{
	internal class Fraction
	{
		public int Integer { get; set; }
		public int Numerator { get; set; }
		int denominator;
		public int Denominator
		{
			get => denominator;
			set => denominator = (value == 0) ? 0 : value;
			//set { denominator = value == 0 ? 0 : value; }
		}

		//		Constructors:

		public Fraction() 
		{ 
			//Integer = 0; Numerator = 0; Denominator = 0;
			Console.WriteLine($"DefaultConstructor:\t{GetHashCode()}");
		}
		public Fraction(int integer) 
		{ 
			Integer = integer; Numerator = 0; Denominator = 0;
			Console.WriteLine($"1ArgConstructor:\t{GetHashCode()}");
		}
		public Fraction(int numerator, int denominator)
		{ 
			Integer = 0; Numerator = numerator; Denominator = denominator;
			Console.WriteLine($"Constructor:\t{GetHashCode()}");
		}
		public Fraction(int integer, int numerator, int denominator)
		{ 
			Integer = integer; Numerator = numerator; Denominator = denominator;
			Console.WriteLine($"Constructor:\t{GetHashCode()}");
		}
		public Fraction(Fraction other)
		{
			Integer = other.Integer;
			Numerator = other.Numerator;
			Denominator = other.Denominator;
			Console.WriteLine($"CopyConstructor:\t{GetHashCode()}");
		}
		~Fraction() { Console.WriteLine($"Destructor:\t{GetHashCode()}"); }

		//		Operators:
		// +-/*; += -= *= /=; == != > <  

		public static Fraction operator*(Fraction l, Fraction r)
		{
			Fraction left = l.Improper();
			Fraction right = r.Improper();
			Fraction result = new Fraction
				(left.Numerator * right.Numerator, left.Denominator * right.Denominator);
			return result;
		}
		public static Fraction operator/(Fraction left, Fraction right)
		{
			return left * right.Reverse();
		}
		public static Fraction operator+(Fraction l, Fraction r)
		{
			//left = left * right.Denominator;
			Fraction left = new Fraction(l.Improper());
			Fraction right = new Fraction(r.Improper());
			if (left.Denominator == right.Denominator)
			{
				left.Numerator += right.Numerator;
				return left;
			}
			else 
			{
				left.Numerator = left.Numerator * right.Denominator + right.Numerator * left.Denominator;
				left.Denominator *= right.Denominator;
				return left;
			}
		}
		public static Fraction operator-(Fraction l, Fraction r)
		{
			Fraction left = new Fraction(l.Improper());
			Fraction right = new Fraction(r.Improper());
			if (left.Denominator == right.Denominator)
			{
				left.Numerator -= right.Numerator;
				return left;
			}
			else
			{
				left.Numerator = left.Numerator * right.Denominator - right.Numerator * left.Denominator;
				left.Denominator *= right.Denominator;
				return left;
			}
		}

		public static bool operator==(Fraction l, Fraction r)
		{
			Fraction left = new Fraction(l.Improper());
			Fraction right = new Fraction(r.Improper());
			if (left.Denominator == right.Denominator)
			{
				return left.Numerator == right.Numerator;
			}
			else
			{
				left.Numerator = left.Numerator * right.Denominator;
				return left.Numerator == right.Numerator * left.Denominator;
			}
		}
		public static bool operator!=(Fraction left, Fraction right)
		{
			return !(left == right);
		}
		public static bool operator>(Fraction left, Fraction right)
		{
			return left.EqualDenominator(right).Numerator > right.EqualDenominator(left).Numerator;
		}
		public static bool operator<(Fraction left, Fraction right)
		{
			return !(left > right);
		}
		public static bool operator >=(Fraction left, Fraction right)
		{
			return (left > right) || (left == right);
		}
		public static bool operator <=(Fraction left, Fraction right)
		{
			return (left < right) || (left == right);
		}

		public static Fraction operator++(Fraction obj)
		{
			obj.Integer += 1;
			obj.Numerator += 1;
			obj.Denominator += 1;
			return obj;
		}

		//		Methods:
		Fraction Improper()
		{
			Fraction copy = new Fraction(this);
			copy.Numerator += copy.Integer * copy.Denominator;
			copy.Integer = 0;
			return copy;
		}
		Fraction Proper()
		{
			Fraction copy = new Fraction(this);
			copy.Integer += copy.Numerator / copy.Denominator;
			copy.Numerator %= copy.Denominator; 
			return copy;
		}
		Fraction Reverse()
		{
			Fraction copy = new Fraction(this);
			copy.Improper();
			int temp = copy.Numerator;
			copy.Numerator = Denominator;
			copy.Denominator = temp;
			return copy;
		}
		Fraction EqualDenominator(Fraction other)
		{
			Fraction copy = new Fraction(Improper());
			if (copy.Denominator == other.Denominator)
			{
				copy.Numerator += other.Numerator;
				return copy;
			}
			else
			{
				copy.Numerator *= other.Denominator;
				copy.Denominator *= other.Denominator;
				return copy;
			}
		}

		public void Print()
		{
			if (Integer != 0) Console.Write(Integer);
			if (Numerator != 0)
			{
				if (Integer != 0) Console.Write("(");
				Console.Write($"{Numerator}/{denominator}");
				if (Integer != 0) Console.Write(")");
			}
			else if (Integer == 0) Console.Write(0);
			Console.WriteLine();
		}
		public override string ToString()
		{
			//return base.ToString();
			string print = "";
			if (Integer != 0) print += Integer;
			if (Numerator != 0)
			{
				if (Integer != 0) print += "(";
				print += $"{Numerator}/{denominator}";
				if (Integer != 0) print += ")";
			}
			else if (Integer == 0) print += 0;

			return print;
		}
	}
}
