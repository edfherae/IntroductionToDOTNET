using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractBaseClass
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Animal animal = new Animal(); //Нельзя создать экземпляр абстрактного класса

			Wolf wolf = new Wolf();
			wolf.Sound();

			Chihuahua chihuahua = new Chihuahua();
			chihuahua.Sound();
		}
	}
}
