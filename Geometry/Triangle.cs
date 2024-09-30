using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Geometry
{
	internal class Triangle : Shape, IHaveHeight
	{
		public int A { get; set; }
		public int B { get; set; }
		public int C { get; set; }

		public Triangle(int start_x, int start_y, int line_width, Color color, int a, int b, int c) : base(start_x, start_y, line_width, color)
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
		public double GetHeight() => 2 * GetArea() / A ;
		public override double GetPerimeter() { return A + B + C; }
		public override double GetArea() { return 0; }
		public override void Draw(PaintEventArgs e)
		{
			Pen pen = new Pen(Color, MIN_LINE_WIDTH);
			Point[] points = new Point[] 
			{ 
				new Point(StartX, StartY),
				new Point (StartX + A,StartY),
				new Point(StartX + A, StartY + B)
			};
			e.Graphics.DrawPolygon(pen, points);
        }
		public override void Info(PaintEventArgs e)
		{
			Console.WriteLine(this.GetType());
			Console.WriteLine($"Высота: {GetHeight()}");
			base.Info(e);
		}
	}
}
