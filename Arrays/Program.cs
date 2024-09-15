//#define ARRAYS_1
//#define ARRAYS_2
#define JAGGED_ARRAY

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
			int sum = 0, avg = 0, min = 0, max = 0;
#if ARRAYS_1
			//int[] arr = new int[] { 1, 2, 3 };
			//int[] arr2 = { 3, 4, 5 };
			Console.Write("Введите количество элементов ");
			int n = Convert.ToInt32(Console.ReadLine());
			int[] arr = new int[n];

			Random rnd = new Random();
			for (int i = 0; i < arr.Length; i++)
			{
				arr[i] = rnd.Next(50, 100);
				Console.Write($"{arr[i]}\t");
			}
			Console.WriteLine();

			for (int i = 0; i < arr.Length; i++)
			{
				Console.Write($"{arr[i]}\t");
			}
			Console.WriteLine();

			max = min = arr[0];
			foreach (int i in arr)
			{
				sum += arr[i];
				if (arr[i] > max) max = arr[i];
				if (arr[i] < min) min = arr[i];
				Console.Write(i + "\t");
			}
			Console.WriteLine($"Sum = {sum}, avg = {sum / arr.Length}, min = {min}, max = {max}");
#endif
#if ARRAYS_2
			//int[,] i_arr_2 = new int[3,4]; //если не инициализируем, указываем размер
			int[,] i_arr_2 = new int[,]
			{
				{3,5,8,13 },
				{21,34,55,89 },
				{144,233,377,610}
			};
			int[,,] arr3 = new int[2, 3, 4];
			//Console.WriteLine((new int[5]).Rank);
			//Console.WriteLine(i_arr_2.Rank);
			//Console.WriteLine((new int[2,3,4]).Rank);
			//Console.WriteLine((new int[2,3,4,5]).Rank);

			Console.WriteLine($"Количество измерений: {i_arr_2.Rank}");
			Console.WriteLine($"Количество измерений в нулевом измерении (количество строк): {i_arr_2.GetLength(0)}");
			Console.WriteLine($"Количество измерений в первом измерении (количество столбцов): {i_arr_2.GetLength(1)}");
			max = min = i_arr_2[0,0];
			for (int i = 0; i < i_arr_2.GetLength(0); i++)
			{
				for (int j = 0; j < i_arr_2.GetLength(1); j++)
				{
					sum += i_arr_2[i,j];
					if (i_arr_2[i, j] > max) max = i_arr_2[i, j];
					if (i_arr_2[i, j] < min) min = i_arr_2[i, j];
					Console.Write(i_arr_2[i, j] + "\t");
				}
			}
			Console.WriteLine();
			Console.WriteLine($"Sum = {sum}, avg = {sum / i_arr_2.Length}, min = {min}, max = {max}");

			foreach (int i in i_arr_2)
			{
				Console.Write(i + "\t");
			}
			Console.WriteLine(); 
#endif
#if JAGGED_ARRAY
			int[][] j_arr = new int[][]
					{
					new int[]{0,1,1,2},
					new int[]{3,5,8,13,21},
					new int[]{34,55,89},
					new int[]{144,233,377,610,987}
					};

			max = min = j_arr[0][0];
			for (int i = 0; i < j_arr.Length; i++)
			{
				for (int j = 0; j < j_arr[i].Length; j++)
				{
					sum += j_arr[i][j];
					if (j_arr[i][j] > max) max = j_arr[i][j];
					if (j_arr[i][j] < min) min = j_arr[i][j];
					Console.Write(j_arr[i][j] + "\t");
				}
				Console.WriteLine();
			}
			Console.WriteLine();
			Console.WriteLine($"Sum = {sum}, avg = {sum / j_arr.Length}, min = {min}, max = {max}");
#endif
		}
	}
}
