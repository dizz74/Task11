using System;

namespace Task11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("kx+b=0");
            Console.WriteLine("k=25 b=14");
            Calc calc;
            calc.k = 25;
            calc.b = 14;
            Console.WriteLine("x равен {0}", calc.Root()) ;
            Console.ReadKey();
        }


        struct Calc {
            public double k;
            public double b;
            public double Root() {
                return  (-b / k);
            }
        }
    }
}
