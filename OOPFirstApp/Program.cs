using System;

namespace OOPFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            const int array_length = 10;

            var data = new int[array_length];

            var adder_5 = GetAdder(7);

            var result = adder_5(5);

            Func<double, double>[] functions = new Func<double, double>[array_length];

            //for (var i = 0; i < array_length; i++)
            //{
            //    functions[i] = GetAdder(i + 1);
            //}

            //var func_result = new double[array_length];
            //for (var i = 0; i < array_length; i++)
            //{
            //    func_result[i] = functions[i](5);
            //}

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

                functions[i] = GetAdder(rnd.Next(5, 11));
            }

            var func_result = new double[array_length];
            for (var i = 0; i < array_length; i++)
            {
                func_result[i] = functions[i](5);
            }

            PrintArray(data, "Исходный массив");

            //Array.Sort(data);
            SortBubble(data);

            PrintArray(data, "Отсортированный массив");

            Console.WriteLine("Нажмите Enter для выхода...");
            Console.ReadLine(); // В конце для предотвращения закрытия окна
        }

        static Func<double, double> GetAdder(int y)
        {
            return x => x + y;
        }

        /// <summary>Сортировка массива методом пузырька</summary>
        /// <param name="Data">Сортируемый массив</param>
        static void SortBubble(int[] Data)
        {
            bool inversion_exists;

            do
            {
                inversion_exists = false;

                for (var i = 0; i < Data.Length - 1; i++)
                {
                    if (Data[i] > Data[i + 1]) // Условие проверки для сортировки по возрастанию
                    //if (Data[i] < Data[i + 1]) // Условие проверки для сортировки по убыванию
                    {
                        inversion_exists = true;

                        //var tmp = Data[i];
                        //Data[i] = Data[i + 1];
                        //Data[i + 1] = tmp;
                        Swap(ref Data[i], ref Data[i + 1]);
                    }
                }
            }
            while (inversion_exists);
        }

        /// <summary>Обмен значений переменных местами</summary>
        static void Swap(ref int x, ref int y)
        {
            var tmp = x;
            x = y;
            y = tmp;
        }

        /// <summary>Печать элементов массива на консоль с заголовком</summary>
        /// <param name="Data">Печатаемый массив</param>
        /// <param name="Header">Текст, выводимый перед началом печати</param>
        static void PrintArray(int[] Data, string Header)
        {
            Console.WriteLine(Header);
            foreach (var value in Data)
                Console.WriteLine(value);
            Console.WriteLine();
        }
    }
}
