using System;

namespace _164
{
    class Program
    {
        

        static void Main()
        {
            Console.WriteLine("Дадени са върховете на тръгълник. Да се съставят методи за\n" +
                "проверка дали съществува такъв триъгълник\n" +
                "намиране на лицето му, когато стойността на предишната е true");
            Console.WriteLine(" Въведете кординати за т. А");
            Console.Write(" xa = ");
            double xa = double.Parse(Console.ReadLine());
            Console.Write(" ya = ");
            double ya = double.Parse(Console.ReadLine());
            Console.WriteLine(" ");

            Console.WriteLine(" Въведете кординати за т. B");
            Console.Write(" xb = ");
            double xb = double.Parse(Console.ReadLine());
            Console.Write(" yb = ");
            double yb = double.Parse(Console.ReadLine());
            Console.WriteLine(" ");

            Console.WriteLine(" Въведете кординати за т. C");
            Console.Write(" xc = ");
            double xc = double.Parse(Console.ReadLine());
            Console.Write(" yc = ");
            double yc = double.Parse(Console.ReadLine());

            Console.WriteLine(" ");
            Console.WriteLine(" ABC триъгълник ? - {0}", Triangle(xa, ya, xb, yb, xc, yc));

            if (Triangle(xa, ya, xb, yb, xc, yc) == true)
            {
                Console.WriteLine(" Лицето на тр. ABC e: {0} кв.см", TriangleS(xa, ya, xb, yb, xc, yc));
            }
            Console.ReadKey();
        }
        static bool Triangle(double xa, double ya, double xb, double yb, double xc, double yc)
        {
            double A = xa + ya;
            double B = xb + yb;
            double C = xc + yc;
            double max = Math.Max(Math.Max(A, B), C);

            bool a = max == A && A > B + C ? true : false;
            bool b = max == B && B > A + C ? true : false;
            bool c = max == C && C > A + B ? true : false;
            bool abc = a == true || b == true || c == true ? true : false;

            return abc;
        }

        static double TriangleS(double xa, double ya, double xb, double yb, double xc, double yc)
        {
            double Xab = xb - xa;
            double Yab = yb - ya;
            double Zab = 0;

            double Xac = xc - xa;
            double Yac = yc - ya;
            double Zac = 0;

            double Xdet = (Yab * Zac) - (Zab * Yac);
            double Ydet = (Zab * Xac) - (Xab * Zac);
            double Zdet = (Xab * Yac) - (Yab * Xac);

            double ABxAC = Math.Sqrt(Math.Pow(Xdet, 2) + Math.Pow(Ydet, 2) + Math.Pow(Zdet, 2));
            double S = 0.5 * ABxAC;

            return S;
        }
    }
}