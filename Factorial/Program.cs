using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

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
            try
            {
                Console.WriteLine("Введите число");
                int n = Convert.ToInt32(Console.ReadLine());
                //Console.WriteLine(factorial(n));
                BigInteger f = 1;

                for (int i = 1; i <= n; i++)
                {
                    f *= i;
                    Console.WriteLine($"{i}! = {f}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
