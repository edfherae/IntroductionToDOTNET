using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
	internal class Circle : Figure
	{
		public int Radius { get; set; }
		public Circle(ConsoleColor color, int radius) : base(color)
		{
			Radius = radius;
			Console.WriteLine($"CConstructor:\t{GetHashCode()}");
		}
		~Circle()
		{
			Console.WriteLine($"CDestructor:\t{GetHashCode()}");
		}

		public override int Perimeter() { return 2 * (int)Math.PI * Radius; }
		public override double Area() { return Math.PI * Radius * Radius; }
		public override void Draw()
		{
            return;
		}
	}
}
