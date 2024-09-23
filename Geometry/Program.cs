using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Triangle triangle = new Triangle(ConsoleColor.Red, 5, 5, 5); //некореектно работает рисовалка
			triangle.Info();

			Circle circle = new Circle(ConsoleColor.Green, 6);
			circle.Info();

			Rectangle rectangle = new Rectangle(ConsoleColor.Cyan, 7, 10);
			rectangle.Info();

			Square square = new Square(ConsoleColor.Magenta, 12);
			square.Info();
        }
	}
}
