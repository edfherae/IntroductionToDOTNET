//#define CONSTRUCTORS_CHECK
#define OPERATORS_CHECK
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fraction
{
	internal class Program
	{
		static string delimiter = "\n-------------------------------------------\n";
		static void Main(string[] args)
		{
#if CONSTRUCTORS_CHECK
			Fraction def = new Fraction();
			def.Print();
			Console.WriteLine(def);

			//Fraction A = 2;
			Fraction A = new Fraction(2);
			A.Print();
			Console.WriteLine(A);

			Fraction B = new Fraction(2, 3);
			B.Print();
			Console.WriteLine(B);

			Fraction C = new Fraction(1, 2, 3);
			C.Print();
			Console.WriteLine(C.GetType());
			Console.WriteLine(C);
#endif

#if OPERATORS_CHECK
			Fraction A = new Fraction(2, 3, 4);
			A.Print();
			Fraction B = new Fraction(3, 4, 5);
			B.Print();

			Fraction C = new Fraction(A * B);
			C.Print();

			Fraction D = new Fraction(A / B);
			D.Print();

			Fraction E = new Fraction(A + B);
			E.Print();

			Fraction F = new Fraction(A - B);
			F.Print();

            Console.WriteLine(delimiter);

            Console.WriteLine(A == B);
            Console.WriteLine(A != B);
            Console.WriteLine(A > B);
            Console.WriteLine(A < B);
            Console.WriteLine(A >= B);
            Console.WriteLine(A <= B);

            Console.WriteLine(delimiter);

            Console.WriteLine(A++);
            Console.WriteLine(++B);
            Console.WriteLine(A--);
            Console.WriteLine(--B);

            Console.WriteLine(delimiter);

			//компилятор сам подставляет
			Console.WriteLine(A += B);
			Console.WriteLine(A -= B);
			Console.WriteLine(A *= B);
			Console.WriteLine(A /= B);
#endif
		} 

	}
}
