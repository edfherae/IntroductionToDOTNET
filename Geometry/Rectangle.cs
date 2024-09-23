using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
	internal class Rectangle : Figure
	{
		public int Width { get;set; }
		public int Height { get;set; }

		public Rectangle(ConsoleColor color, int width, int height) : base(color)
		{
			Width = width;
			Height = height;
			Console.WriteLine($"RConstructor:\t{GetHashCode()}");
		}
		~Rectangle()
		{
			Console.WriteLine($"RDestructor:\t{GetHashCode()}");
		}

		public override int Perimeter() { return Width * 2 + Height * 2; }
		public override double Area() { return Width * Height; }
		public override void Draw()
		{
			Console.ForegroundColor = Color;
			Console.BackgroundColor = Color;
			for (int i = 0; i < Width; i++)
			{
				for (int j = 0; j < Height; j++)
				{
					Console.Write('*');
				}
				Console.WriteLine();
			}
			Console.ResetColor();
		}
	}
}
