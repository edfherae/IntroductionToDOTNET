using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
	internal class Triangle : Figure
	{
		public int A { get; set; }
		public int B { get; set; }
		public int C { get; set; }

		public Triangle(ConsoleColor color, int a, int b, int c) : base(color)
		{
			A = a;
			B = b;
			C = c;
			Console.WriteLine($"TConstructor:\t{GetHashCode()}");
		}
		~Triangle()
		{
			Console.WriteLine($"TDestructor:\t{GetHashCode()}");
		}

		public override int Perimeter() { return A + B + C; }
		public override double Area() { return 0; }
		public override void Draw()
		{
            for (int i = 0; i < A; i++)
            {
                for (int j = 0; j < i + 1; j++)
                {
					Console.Write('*');
                }
				Console.WriteLine();
            }
        }
	}
}
