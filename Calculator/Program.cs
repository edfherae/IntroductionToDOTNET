using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.Title = "Calc";
            Console.WriteLine("Калькулятор. Напишите break, чтобы завершить работу");

            while (true)
			{
				//string[3]
				string input_data;
				string[] temp = { "1" };
				do
				{
					try
					{
						input_data = Console.ReadLine();
						temp = input_data.Split(' ');
						break;
					}
					catch (Exception ex)
					{
                        Console.WriteLine(ex.Message);
                        Console.WriteLine("Введите всё нормально");
                    }
				} while (true);
				if (temp[0].Equals("break")) break;

				/*for (int i = 0; i < temp.Length; i++)
				{
					Console.WriteLine(temp[i]);
					//Console.WriteLine(temp[i].GetType());
				}*/
				double left_operand = Convert.ToDouble(temp[0]);
				double right_operand = Convert.ToDouble(temp[2]);
				char op = Convert.ToChar(temp[1]);
				//op = ConsoleKey.Add
				
				double result = 0;
				switch (op)
				{
					//temp.contains('+')
					case '+': result = left_operand + right_operand; break;
					case '-': result = left_operand - right_operand; break;
					case '*': result = left_operand * right_operand; break;
					case '/': result = left_operand / right_operand; break;
					case '%': result = left_operand % right_operand; break;
					case '^':
						result = 1;
						for (int i = 0; i < right_operand; i++) result *= left_operand;
						break;
					default: Console.WriteLine("Такой оператор не предусмотрен"); break;
				}

				Console.WriteLine($"{left_operand} {op} {right_operand} = {result}"); 
			}
		}
	}
}
