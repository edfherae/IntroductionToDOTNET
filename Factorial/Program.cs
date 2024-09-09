using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    internal class Program
    {
        static int factorial(int n)
        {
            if (n == 1) return 1;
            return factorial(n - 1) * n;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int value = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(factorial(value));

            int result = value;
            for (int i = 1; i != value - 1; i++)
            {
                result *= value - i;
            }
            Console.WriteLine(result);
        }
    }
}
