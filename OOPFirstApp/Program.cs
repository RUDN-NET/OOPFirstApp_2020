using System;

namespace OOPFirstApp
{
    class Program
    {
        public static DateTime StartTime; // Поле класса - статическое поле

        static void Main(string[] args)
        {
            StartTime = DateTime.Now;

            Arrays.Start();

            Console.WriteLine("Нажмите Enter для выхода...");
            Console.ReadLine(); // В конце для предотвращения закрытия окна
        }
    }
}
