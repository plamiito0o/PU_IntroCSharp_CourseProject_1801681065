using System;

namespace ConvertNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Превърнете числото 2065 в двоична, осмична и шестнайсетична бройна система");
            int number = 2065;
            string NumberIn2 = Convert.ToString(number, 2);
            string NumberIn8 = Convert.ToString(number, 8);
            string NumberIn16 = Convert.ToString(number, 16);
            Console.WriteLine(NumberIn2);
            Console.WriteLine(NumberIn8);
            Console.WriteLine(NumberIn16);
            Console.ReadKey();
        }
    }
}
