//#define OUTPUT_TO_SCREEN

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToDOTNET
{
    internal class Program
    {
        static void Main(string[] args)
        {
#if OUTPUT_TO_SCREEN
            Console.Title = "Introduction to .NET";
            Console.WriteLine("Hello .NET");

            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.CursorLeft = 24; // x курсора
            Console.CursorTop = 12; // y курсора

            Console.SetCursorPosition(16, 5);
            Console.WriteLine("ля ля ля");
            Console.ResetColor();

            //Console.WindowWidth = 64;
            //Console.WindowHeight = 16;
            Console.SetWindowSize(64, 16);

            #region CodeSnippet
            //Console.WindowLeft = 10;
            //Console.WindowTop = 10;
            //Console.SetWindowPosition(10, 10); 
            #endregion

            Console.BufferWidth = Console.WindowWidth;
            Console.BufferHeight = Console.WindowHeight;
            //буффер должен быть больше, чем размер окна  
#endif

            Console.Write("Введите ваше имя: ");
            string first_name = Console.ReadLine(); //Метод ReadLine читает строку с клавиатуры до нажатия enter
                                                    //и возвращает прочитанную строку
            Console.WriteLine(first_name);

            Console.WriteLine("Введите вашу фамилию: ");
            string last_name = Console.ReadLine();
            Console.WriteLine(last_name);

            Console.WriteLine("Введите ваш возраст: ");
            int age = Convert.ToInt32(Console.ReadLine()); //класс Convert дает набор статических методов для преобразования типов
                                                           //используется, как правило, в том случае, когда другие преобразования не работают
                                                           //16 - short, 32 - int, 64 - long
            Console.WriteLine(last_name + " " + first_name + ", " + age); //конкатенация

            Console.WriteLine(String.Format("{0} {1}, {2} years", last_name, first_name, age)); //форматирование

            Console.WriteLine($"{last_name} {first_name}, {age} years"); //интерполяция строк
        }
    }
}
