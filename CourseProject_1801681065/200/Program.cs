using System;

namespace _200
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Да се състави алгоритъм за изчисляване на решенията на система \n" +
                "от две линейни уравнения с две незвестни\n" +
                " ax+by=c \n" +
                " dx+ey=f " +
                "където a,b,d,e са коефиценти и c,f са свободни членове");
            Console.Write("a=");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b=");
            double b = double.Parse(Console.ReadLine());
            Console.Write("c=");
            double c = double.Parse(Console.ReadLine());
            Console.Write("d=");
            double d = double.Parse(Console.ReadLine());
            Console.Write("e=");
            double e = double.Parse(Console.ReadLine());
            Console.Write("f=");
            double f = double.Parse(Console.ReadLine());
            double det = a * e - b * d;
            double d1 = c * e - b * f;
            double d2 = a * f - c * d;
            double x = d1 / det;
            double y = d2 / det;
            Console.WriteLine($"x=" + x);
            Console.WriteLine($"y=" + y);
            Console.ReadKey();
        }
    }
}
