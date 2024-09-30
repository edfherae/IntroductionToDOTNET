using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace Geometry
{
	internal class Square : Rectangle
	{
		public Square(double side, int start_x, int start_y, int line_width, Color color)
			: base(side, side, start_x, start_y, line_width, color) {}
	}
}
