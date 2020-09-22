using System;

namespace OOPFirstApp
{
    class Complex
    {
        public double Re;
        public double Im;

        public void Print()
        {
            Console.WriteLine("{0}+i{1}", Re, Im);
        }

        public Complex Add(Complex y)
        {
            var z = new Complex();
            z.Re = Re + y.Re;
            z.Im = Im + y.Im;

            return z;
        }

        public double GetAbs()
        {
            return Math.Sqrt(Re * Re + Im * Im);
        }

        public double GetArg()
        {
            return Math.Atan2(Im, Re);
        }

        public static Complex operator +(Complex x, Complex y)
        {
            var z = new Complex();
            z.Re = x.Re + y.Re;
            z.Im = x.Im + y.Im;

            return z;
        }

        public static Complex operator -(Complex x, Complex y)
        {
            var z = new Complex();
            z.Re = x.Re - y.Re;
            z.Im = x.Im - y.Im;

            return z;
        }
    }
}