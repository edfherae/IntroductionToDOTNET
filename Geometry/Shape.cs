using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms; //explorer - references - add reference
using System.Drawing;

namespace Geometry
{
	abstract internal class Shape
	{
		public static readonly int MIN_START_X = 50;
		public static readonly int MAX_START_X = 1000;
		public static readonly int MIN_START_Y = 50;
		public static readonly int MAX_START_Y = 500;
		public static readonly int MIN_LINE_WIDTH = 1;
		public static readonly int MAX_LINE_WIDTH = 16;
		public static readonly int MIN_SIZE = 20;
		public static readonly int MAX_SIZE = 320;

		int start_x;
		int start_y;
		int line_width;
		public Color Color {get;set;}
		public int StartX
		{
			get => start_x;
			set
			{
				if (value < MIN_START_X) value = MIN_START_X;
				if (value > MAX_START_X) value = MAX_START_X;
				this.start_x = value;
			}
		}
		public int StartY
		{
			get => start_y;
			set => start_y =
				value < MIN_START_Y ? MIN_START_Y :
				value > MAX_START_Y ? MAX_START_Y :
				value;
		}
		public int LineWidth
		{
			get => line_width;
			set => line_width =
				value < MIN_LINE_WIDTH ? MIN_LINE_WIDTH :
				value > MAX_LINE_WIDTH ? MAX_LINE_WIDTH :
				value;
		}
		public static int Count { get; set; }

		public Shape(int start_x, int start_y, int line_width, Color color)
		{
			Color = color;
			StartX = start_x;
			StartY = start_y;
			LineWidth = line_width;
			Count++;
            Console.WriteLine($"FConstructor:\t{GetHashCode()}, количество фигур: {Count}");
        }
		~Shape()
		{
			Count--;
            Console.WriteLine($"FDestructor:\t{GetHashCode()}, количество фигур: {Count}");
		}

		//		Methods:

		public abstract double GetArea();
		public abstract double GetPerimeter();
		public abstract void Draw(PaintEventArgs e);
		public virtual void Info(PaintEventArgs e)
		{
			Console.WriteLine($"Площадь фигуры: {GetArea()}");
			Console.WriteLine($"Периметр фигуры: {GetPerimeter()}");
			Draw(e);
		}

	}
}
