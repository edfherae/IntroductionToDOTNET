//#define NUMERIC_TYPES
//#define LITERALS
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataTypes
{
    internal class Program
    {
        static readonly string delimiter1 = "\n------------------------------------------------\n";
        static readonly string delimiter2 = "\n================================================\n";
        static void Main(string[] args)
        {
            Console.Title = "DataTypes";
            Console.SetBufferSize(Console.BufferWidth, Console.BufferHeight);

#if NUMERIC_TYPES
            //
            #region Boolean
            //Console.WriteLine(bool.TrueString); //bool - спецификатор типа, ключевое слово
            //Console.WriteLine(Convert.ToBoolean(100)); //преобразовывать типы можно только спец. функциями
            //Console.WriteLine(bool.Parse("TRue")); 
            #endregion

            #region Char
            // Char.
            //Console.WriteLine(char.GetNumericValue(char.MinValue));
            //Console.WriteLine(char.GetNumericValue(char.MaxValue));
            //Console.WriteLine(sizeof(char)); 
            #endregion

            #region IntegralTypes
            ////Int16.
            //Console.WriteLine($"sizeof(short): {sizeof(Int16)}");
            //Console.WriteLine($"MinValue: {short.MinValue}\nMaxValue: {short.MaxValue}");
            //Console.WriteLine($"ushort min, max: {UInt16.MinValue}, {ushort.MaxValue}");

            //Console.WriteLine(delimiter1);

            //Console.WriteLine($"sizeof(int): {sizeof(Int32)}");
            //Console.WriteLine($"MinValue: {int.MinValue}\nMaxValue: {int.MaxValue}");
            //Console.WriteLine($"uint min, max: {UInt32.MinValue}, {uint.MaxValue}");

            //Console.WriteLine(delimiter1);

            //Console.WriteLine($"sizeof(int): {sizeof(Int64)}");
            //Console.WriteLine($"MinValue: {long.MinValue}\nMaxValue: {Int64.MaxValue}");
            //Console.WriteLine($"ulong min, max: {UInt64.MinValue}, {ulong.MaxValue}"); 
            #endregion

            Console.WriteLine($"sizeof(float): {sizeof(Single)}");
            Console.WriteLine($"MinValue: {float.MinValue}\nMaxValue: {Single.MaxValue}");

            Console.WriteLine(delimiter1);

            Console.WriteLine($"sizeof(double): {sizeof(Double)}");
            Console.WriteLine($"MinValue: {double.MinValue}\nMaxValue: {Double.MaxValue}");

            Console.WriteLine(delimiter1);

            Console.WriteLine($"sizeof(decimal): {sizeof(Decimal)}");
            Console.WriteLine($"MinValue: {decimal.MinValue}\nMaxValue: {Decimal.MaxValue}"); 
#endif

#if LITERALS
            Console.WriteLine(byte.MaxValue);
            Console.WriteLine(123.GetType());
            Console.WriteLine(123u.GetType());
            Console.WriteLine(123l.GetType());
            Console.WriteLine(123UL.GetType());
            Console.WriteLine(123.4.GetType());
            Console.WriteLine(123.4D.GetType());
            Console.WriteLine(123.4f.GetType());
            Console.WriteLine(123f.GetType());
            Console.WriteLine(123.4m.GetType());

            Console.WriteLine(delimiter1);

            Console.WriteLine('+'.GetType());
            Console.WriteLine("Hello".GetType()); 
#endif

            Console.WriteLine(((byte)5).GetType().Name);

            #region Convertions1
            //byte a = 2;
            //uint b = uint.MaxValue;
            //Console.WriteLine(a + " " + b);
            //a = (byte)b;
            //Console.WriteLine(a + " " + b); 
            #endregion

            int a = int.MaxValue;
            uint b = uint.MaxValue;

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(a + b);
            Console.WriteLine((a + b).GetType().Name);

            long l = long.MaxValue;
            try
            {
                Console.WriteLine(l + b);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                //throw;
            }
            Console.WriteLine("to the moon");

            #region POINTER_CREATION
            //char[] test = new char[3] { 'a','b','c' };
            //Console.WriteLine(test);
            //int a = 2;
            //unsafe
            //{
            //    int* pa = &a; 
            //    Console.WriteLine(*pa);
            //} 
            #endregion
        }
    }
}
