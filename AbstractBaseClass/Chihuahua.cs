using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractBaseClass
{
	internal class Chihuahua : Dog
	{
		public override void Sound()
		{
            Console.WriteLine("Тяф");
        }
	}
}
