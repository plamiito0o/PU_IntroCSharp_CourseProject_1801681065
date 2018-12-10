using System;

namespace _55
{

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Напишете програма за изчисляване на функцията:\n" +
                "f(y,z)={y*y+z*z+1, y<=0 && z>0\n" +
                "       {y*z+1, y>0 && z<0");
            Console.WriteLine(" Функция f(y,z)");
            Console.Write("  y = ");
            int y = int.Parse(Console.ReadLine());
            Console.Write("  z = ");
            int z = int.Parse(Console.ReadLine());
            double r;
            if (y <= 0 && z >= 0)
            {
                r = Math.Pow(y, 2) + Math.Pow(z, 2) + 1;
                Console.WriteLine(" f(y,z) = {0}", r);
            }
            else if (y > 0 && z < 0)
            {
                r = (y * z) + 1;
                Console.WriteLine(" f(y,z) = {0}", r);
            }
            else
            {
                Console.WriteLine(" Невалидни стойности за функцията !");
            }
            Console.ReadKey();
        }
    }
}