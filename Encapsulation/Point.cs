using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
	internal class Point
	{
		//double x, y;
		//public double X
		//{ 
		//	get
		//	{
		//		return x;
		//	}
		//	set 
		//	{ 
		//		x = value; //value открывает доступ к переданному значению
		//	}
		//}
		//public double Y
		//{
		//	get { return y; }
		//	set { y = value; }
		//}
		//public double GetX()
		//{
		//	return x;
		//}
		//public double GetY()
		//{
		//	return y;
		//}
		//public void SetX(double x) { this.x = x; }
		//public void SetY(double y) { this.y = y; }

		public double X { get; set; } //автосвойства для x
		public double Y { get; set; } //автосвойства для y
		//		Constructor:
		public Point(double x = 0, double y = 0) //универсальный, и без, и с одним, и с двумя
		{
			X = x; 
			Y = y;
            Console.WriteLine($"Constructor:\t{this.GetHashCode()}");
        }
		public Point(Point other)
		{
			X = other.X;
			Y = other.Y;
            Console.WriteLine($"CopyConstructor:\t{GetHashCode()}");
		}
		~Point()
		{
			Console.WriteLine($"Destructor:\t{this.GetHashCode()}");
		}
		//		Operators:
		public static Point operator+(Point left, Point right)
		{
			return new Point(left.X + right.X, left.Y + right.Y);
		}
		public static Point operator++(Point obj)
		{
			obj.X++;
			obj.Y++;
			return obj;
		}
		public static bool operator==(Point left, Point right)
		{
			return left.X == right.X && left.Y == right.Y;
		}
		public static bool operator!=(Point left, Point right)
		{
			return !(left == right);
		}

		//		Methods
		public void print()
		{
			//Console.WriteLine($"X = {this.GetX()}, X = {this.GetY()}");
			Console.WriteLine($"X = {this.X}, X = {this.Y}");
		}
		public double Distance(Point other)
		{
			double x_distance = (X > other.X) ? X - other.X : X - other.X;
			double y_distance = (Y > other.Y) ? Y - other.Y : Y - other.Y;
			return Math.Sqrt(x_distance * x_distance + y_distance * y_distance);
		}
		static public double Distance(Point a, Point b)
		{
			double x_distance = (a.X > b.X) ? a.X - b.X : b.X - a.X;
			double y_distance = (a.Y > b.Y) ? a.Y - b.Y : b.Y - a.Y;
			return Math.Sqrt(x_distance * x_distance + y_distance * y_distance);
		}
	}
}
