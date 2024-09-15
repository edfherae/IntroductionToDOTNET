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
		~Point()
		{
			Console.WriteLine($"Destructor:\t{this.GetHashCode()}");
		}

		//		Methods
		public void print()
		{
			//Console.WriteLine($"X = {this.GetX()}, X = {this.GetY()}");
			Console.WriteLine($"X = {this.X}, X = {this.Y}");
		}
	}
}
