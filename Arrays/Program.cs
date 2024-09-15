using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//int[] arr = new int[] { 1, 2, 3 };
			//int[] arr2 = { 3, 4, 5 };
			Console.Write("Введите количество элементов ");
			int n = Convert.ToInt32(Console.ReadLine());
			int[] arr = new int[n];

			Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
			{
				arr[i] = rnd.Next();
                Console.Write($"{arr[i]}\t");
            }
			int[,,] arr3 = new int[2,3,4];
		}
	}
}
