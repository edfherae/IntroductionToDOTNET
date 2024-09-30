using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Drawing;

namespace Geometry
{
	internal class Rectangle : Shape, IHaveDiagonal
	{
		double width;
		double height;
		public double Width
		{
			get => width;
			set => width =
				value < MIN_SIZE ? MIN_SIZE :
				value > MAX_SIZE ? MAX_SIZE :
				value;
		}
		public double Height
		{
			get => height;
			set => height =
				value < MIN_SIZE ? MIN_SIZE :
				value > MAX_SIZE ? MAX_SIZE :
				value;
		}

		public Rectangle(double width, double height, int start_x, int start_y, int line_width, Color color)
			: base(start_x, start_y, line_width, color)
		{
			Width = width;
			Height = height;
		}
		~Rectangle()
		{
			Console.WriteLine($"RDestructor:\t{GetHashCode()}");
		}

		public double GetDiagonal() => Math.Sqrt(Math.Pow(Width, 2) + Math.Pow(Height, 2));
		public override double GetArea() => Width * Height;
		public override double GetPerimeter() => (Width + Height) * 2;
		public override void Draw(PaintEventArgs e)
		{
			Pen pen = new Pen(Color, LineWidth);
			e.Graphics.DrawRectangle(pen, StartX, StartY, (float)Width, (float)Height);
		}
		public void DrawDiagonal(PaintEventArgs e)
		{
			Pen pen = new Pen(Color, 1);
			e.Graphics.DrawLine(pen, StartX, StartY, StartX + (int)Width, StartY + (int)Height);
		}
		public override void Info(PaintEventArgs e)
		{
			Console.WriteLine(this.GetType() + ":");
			Console.WriteLine($"Ширина: {Width}");
			Console.WriteLine($"Высота: {Height}");
			Console.WriteLine($"Диагональ: {GetDiagonal()}");
			DrawDiagonal(e);
			base.Info(e);
		}
	}
}
