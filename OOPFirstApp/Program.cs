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

            //ComplexTests.Start();

            Gun gun1 = new Gun();
            Gun gun2 = new Gun(5, '#');
            //gun2.ShotSymbol = '*';

            gun2.SetAmmoCount(-5);

            Console.WriteLine("В первом ружье {0} патронов", gun1.GetAmmoCount());
            gun1.SetAmmoCount(10);
            Console.WriteLine("В первом ружье {0} патронов", gun1.GetAmmoCount());

            Console.WriteLine("Первое ружьё");
            for (var i = 0; i < 7; i++)
                gun1.Shot();
            Console.WriteLine();


            Console.WriteLine("Второе ружьё");
            for (var i = 0; i < 7; i++)
                gun2.Shot();
            Console.WriteLine();

            gun1.LoadAmmo(2);
            gun2.LoadAmmo(7);

            Console.WriteLine("Первое ружьё");
            for (var i = 0; i < 7; i++)
                gun1.Shot();
            Console.WriteLine();


            Console.WriteLine("Второе ружьё");
            for (var i = 0; i < 7; i++)
                gun2.Shot();
            Console.WriteLine();

            Console.WriteLine("Нажмите Enter для выхода...");
            Console.ReadLine(); // В конце для предотвращения закрытия окна
        }
    }

    class Gun
    {
        private int _AmmoCount;
        private char _ShotSymbol = '|';

        public int GetAmmoCount()
        {
            return _AmmoCount;
        }

        public void SetAmmoCount(int value)
        {
            if(value < 0)
                throw new ArgumentOutOfRangeException("value", value, "Число патронов не может быть меньше 0");

            _AmmoCount = value;
        }
        
        public Gun()
        {
            _AmmoCount = 3;
            Console.WriteLine("Создано новое ружьё");
        }

        public Gun(int count)
        {
            _AmmoCount = count;
            Console.WriteLine("Создано новое ружьё с числом патронов {0}", _AmmoCount);
        }

        public Gun(int count, char symbol)
        {
            _AmmoCount = count;
            _ShotSymbol = symbol;
            Console.WriteLine("Создано новое ружьё с числом патронов {0} ({1})",
                _AmmoCount, _ShotSymbol);
        }

        public void Shot()
        {
            if (_AmmoCount > 0)
            {
                Console.WriteLine(_ShotSymbol);
                _AmmoCount--;
            }
            else
                Console.WriteLine("Патроны закончились");
        }

        public void LoadAmmo(int count)
        {
            _AmmoCount += count;
        }
    }
}
