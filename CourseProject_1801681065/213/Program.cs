using System;

namespace _213
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Да се изчисли 1/2*1/4...1/50");
            double s = 1;
              for(int i=2; i <= 50; i++)
              {
                s *= (1.0 / i);
              }
            Console.WriteLine(" 1/2*1/4...1/50="+ s);
            Console.ReadKey();
        }
    }
}
