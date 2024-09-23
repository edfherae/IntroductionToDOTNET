using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
	abstract internal class Figure
	{
		public ConsoleColor Color { get; set; }
		public static int Count { get; set; }

		public Figure(ConsoleColor color)
		{
			Color = color;
			Count++;
            Console.WriteLine($"FConstructor:\t{GetHashCode()}, количество фигур: {Count}");
        }
		~Figure()
		{
			Count--;
            Console.WriteLine($"FDestructor:\t{GetHashCode()}, количество фигур: {Count}");
		}

		//		Methods:

		public abstract int Perimeter();
		public abstract double Area();
		public abstract void Draw();
		public virtual void Info()
		{
            Console.WriteLine(ToString());
            Draw();
		}

	}
}
