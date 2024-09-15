using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Point A = new Point(); //оператор new вызывает конструктор
			//A.SetX(10); A.SetY(10);
			//Console.WriteLine($"x = {A.GetX()}, y = {A.GetY()}");

			Point B = new Point(); //default constr, в B записывается ссылка
			B.X = 7;
			B.Y = 8;
			B.print();

			Point C = new Point(11, 12);
			C.print();

            Console.WriteLine(B.Distance());
            Console.WriteLine(C.Distance());
            Console.WriteLine(Point.Distance(B, C));
        }
	}
}
