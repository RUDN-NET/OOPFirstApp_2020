using System;

namespace OOPFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            const int array_length = 50;

            var data = new int[array_length];

            var rnd = new Random();
            for (var i = 0; i < array_length; i++)
            {
                //var x_random = (rnd.NextDouble() - 0.5) * 2 * 5;
                //var int_random = rnd.Next();
                //var int2_random = rnd.Next(51); // 0..50
                //data[rnd.Next(data.Length)] = 5; // Запись значения в случайную ячейку массива
                //var random_data = data[rnd.Next(array_length)]; // Получить значение из случайной ячейки
                //var int3_random = rnd.Next(-50,51); // -50..50

                data[i] = rnd.Next(0, 101);
            }

            PrintArray(data, "Исходный массив");

            Console.WriteLine("Нажмите Enter для выхода...");
            Console.ReadLine(); // В конце для предотвращения закрытия окна
        }

        static void PrintArray(int[] Data, string Header)
        {
            Console.WriteLine(Header);
            foreach (var value in Data)
                Console.WriteLine(value);
            Console.WriteLine();
        }
    }
}
