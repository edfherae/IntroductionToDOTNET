﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    internal class Program
    {
        static readonly string delimiter1 = "\nЗадание ";
        static void Main(string[] args)
        {
            Console.WriteLine(delimiter1 + 0);
            Console.WriteLine();

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                    Console.Write('*');
            Console.WriteLine();
            }

            Console.WriteLine(delimiter1 + 1);
            Console.WriteLine();

            for (int i = 1; i < 6; i++)
            {
                for (int j = 1; j < i + 1; j++) Console.Write('*');
                Console.WriteLine();
            }

            Console.WriteLine(delimiter1 + 2);
            Console.WriteLine();

            for(int i = 1; i < 6; i++)
            {
                for (int j = 6 - i; j > 0; j--) Console.Write('*');
                Console.WriteLine();
            }

            Console.WriteLine(delimiter1 + 3);
            Console.WriteLine();

            for (int i = 0; i < 5; i++)
            {
                for (int j = 1; j < 6; j++)
                    Console.Write((j > i) ? '*' : ' ');
                Console.WriteLine();
            }

            Console.WriteLine(delimiter1 + 4);
            Console.WriteLine();

            for (int i = 1; i < 6; i++)
            {
                for (int j = 6; j > 0; j--)
                    Console.Write((j > i) ? ' ' : '*');
                Console.WriteLine();
            }
            
            Console.WriteLine(delimiter1 + 5);
            Console.WriteLine();

            for (int i = 0; i < 10; i++)
            {
                int count = 5;
                for (int j = 0; j < 10; j++)
                {
                    if (j == count) Console.Write('/'); else if (j == count + 1) Console.WriteLine('\\');
                    else Console.Write(' ');
                }
                Console.WriteLine();
            }

            Console.WriteLine(delimiter1 + 6);
            Console.WriteLine();

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0 + i; j < 5 + i; j++)
                    Console.Write((j % 2 == 0) ? '+' : '-');
                Console.WriteLine();
            }
            
            //Console.SetCursorPosition(Console.WindowWidth / 2, 1);
            //Console.WriteLine("⬜ and ░ and \x2591 and █");
            Console.WriteLine("\nНажмите любую клавишу, чтобы перейти к следующему заданию\n");
            Console.ReadKey();
            Console.Clear();

            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("Введите размер доски");
            int size = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < size + 2; i++)
            {
                Console.Write("‗");
            }
            Console.WriteLine();

            for (int i = 0; i < size; i++)
            {
                Console.Write("‖");  
                for (int j = 0 + i; j < size + i; j++)
                {
                    Console.Write((j % 2 == 0) ? '█' : '░');
                }
                Console.Write("‖");
                Console.WriteLine();
            }

            for (int i = 0; i < size + 2; i++)
            {
                Console.Write("̿");
            }

            Console.WriteLine("\nНажмите любую клавишу, чтобы перейти ко второму заданию\n");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Введите размер доски");
            size = Convert.ToInt32(Console.ReadLine());
            bool flag = true;
            for (int i = 0; i < size; i++)
            {
                for(int k = 0; k < 5; k++) 
                {
                    for (int j = 1; j < size + 1; j++)
                    {
                        if (j % 5 == 0) flag = !flag;
                        Console.Write((flag) ? "*" : " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                
                flag = true;
                for (int k = 0; k < 5; k++)
                {
                    for (int j = 1; j < size + 1; j++)
                    {
                        if (j % 5 == 0) flag = !flag;
                        Console.Write((flag) ? " " : "*");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
    }
}
