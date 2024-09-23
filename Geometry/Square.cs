using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
	internal class Square : Rectangle
	{
		public Square(ConsoleColor color, int side) : base(color, side, side)
		{ Width = Height = side; Color = color; }
	}
}
