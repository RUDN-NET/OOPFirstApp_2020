using System;

namespace OOPFirstApp
{
    class Program
    {
        public static DateTime StartTime; // Поле класса - статическое поле

        static void Main(string[] args)
        {
            //StartTime = DateTime.Now;
            //Arrays.Start();

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

            Console.WriteLine("Нажмите Enter для выхода...");
            Console.ReadLine(); // В конце для предотвращения закрытия окна
        }
    }

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
