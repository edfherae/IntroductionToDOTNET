//#define CONSTRUCTORS_CHECK
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
	internal class Program
	{
		static string delimiter = "\n------------------------------------------------\n";
		static void Main(string[] args)
		{
#if CONSTRUCTORS_CHECK
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

			Point D = C; //здесь копируется не объект, а ссылка на него
			D.print();
			D.X = 111;
			C.print();

			//как происходит копирование:
			Point E = new Point(D); //при передаче в функцию тоже копируется ссылка
									//копируется объект только при помоще new
			D.X = 0;
			E.print();

			E = new Point(B);
			E.print(); 
#endif
			Point A = new Point(2,3);
			Point B = new Point(7,8);
			Point C = new Point(A + B);
			C.print();

            for (Point i = new Point(); i.X < 10; ++i)
            {
				i.print();
            }

			Point n = new Point(10, 10);
            for (Point i = new Point(); i != n; ++i)
            {
				i.print();
            }
        }
	}
}
