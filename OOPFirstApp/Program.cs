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

            Complex z = new Complex();

            z.Re = 5;
            z.Im = 7;

            Console.WriteLine("z = {0}+i{1}", z.Re, z.Im);
            Console.WriteLine();
            z.Print();

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
            Console.WriteLine("z = {0}+i{1}", Re, Im);
        }
    }
}
