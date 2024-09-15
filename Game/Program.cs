using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Game";

            Console.BufferWidth = Console.WindowWidth;
            Console.BufferHeight = Console.WindowHeight;

            Random temp = new Random();
            int left = temp.Next(Console.BufferWidth);
            int top = temp.Next(Console.BufferHeight);
            Console.SetCursorPosition(left, top);
            ConsoleKey key;

            //почему мы не можем сравнить int и enum

            do
            {
                key = Console.ReadKey(true).Key;
                Console.WriteLine(key);
                //ConsoleKey.

                if (key == ConsoleKey.W || key == ConsoleKey.UpArrow) top -= (top > 1) ? 1 : 0;
                else if (key == ConsoleKey.A || key == ConsoleKey.LeftArrow) left -= (left > 1) ? 1 : 0;
                else if (key == ConsoleKey.S || key == ConsoleKey.DownArrow) top += (top < Console.BufferHeight) ? 1 : 0;
                else if (key == ConsoleKey.D || key == ConsoleKey.RightArrow) left += (left < Console.BufferWidth) ? 1 : 0;
                Console.SetCursorPosition(left, top);
            } while (key != ConsoleKey.Escape);
        }
    }
}
