using System;

namespace OOPFirstApp
{
    class ComplexTests
    {
        public static void Start()
        {
            Complex x = new Complex();
            x.Re = 5;
            x.Im = 7;

            Complex y = new Complex();
            y.Re = 7;
            y.Im = 10;

            var z = x.Add(y);
            var z1 = x + y;
            var z2 = x - y;

            x.Print();
            y.Print();
            z.Print();
            z1.Print();
            z2.Print();

            Console.WriteLine("|z| = " + z.GetAbs());
            Console.WriteLine("arg(z) = " + z.GetArg() * 180 / Math.PI);
        }
    }
}
