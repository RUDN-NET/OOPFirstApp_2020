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

            //Gun gun1 = new Gun();
            //Gun2 gun2 = new Gun2(5, '#');
            ////gun2.ShotSymbol = '*';



            ////gun2.SetAmmoCount(-5);
            //gun1.AmmoCount = 5;
            ////gun2.AmmoCount = -6;
            //gun1.ShotSymbol = '-';

            //Console.WriteLine("В первом ружье {0} патронов", gun1.GetAmmoCount());
            //gun1.SetAmmoCount(10);
            //Console.WriteLine("В первом ружье {0} патронов", gun1.GetAmmoCount());

            //Console.WriteLine("Первое ружьё");
            //for (var i = 0; i < 7; i++)
            //    gun1.Shot();
            //Console.WriteLine();


            //Console.WriteLine("Второе ружьё");
            //for (var i = 0; i < 7; i++)
            //    gun2.Shot();
            //Console.WriteLine();

            //gun1.LoadAmmo(2);
            //gun2.LoadAmmo(7);

            //Console.WriteLine("Первое ружьё");
            //for (var i = 0; i < 7; i++)
            //    gun1.Shot();
            //Console.WriteLine();


            //Console.WriteLine("Второе ружьё");
            //for (var i = 0; i < 7; i++)
            //    gun2.Shot();
            //Console.WriteLine();

            //Gun gun = new Gun(5);

            //for (var i = 0; i < 7; i++)
            //    gun.Shot();

            //gun = new Gun2(7, '*');
            //for (var i = 0; i < 7; i++)
            //    gun.Shot();

            //gun = new Gun3(8, '#');
            //for (var i = 0; i < 7; i++)
            //    gun.Shot();

            ShotFromWeapon(new Gun());
            ShotFromWeapon(new Gun2(7, '*'));
            ShotFromWeapon(new Gun3(8, '#'));

            ShotFromWeapon(new PistolWithUnlimitedAmmo());
            ShotFromWeapon(new RifleGunWithUnlimitedAmmo());

            Console.WriteLine("Нажмите Enter для выхода...");
            Console.ReadLine(); // В конце для предотвращения закрытия окна
        }

        static void ShotFromWeapon(Weapon weapon, int count = 7)
        {
            for (var i = 0; i < count; i++)
                weapon.Shot();
        }
    }

    abstract class Weapon
    {
        public abstract void Shot();
    }

    class Gun : Weapon
    {
        protected int _AmmoCount;
        protected char _ShotSymbol = '|';

        public int GetAmmoCount()
        {
            return _AmmoCount;
        }

        public void SetAmmoCount(int value)
        {
            if (value < 0)
                throw new ArgumentOutOfRangeException("value", value, "Число патронов не может быть меньше 0");

            _AmmoCount = value;
        }

        public int AmmoCount
        {
            get
            {
                return _AmmoCount;
            }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("value", value, "Число патронов не может быть меньше 0");

                _AmmoCount = value;
            }
        }

        public char ShotSymbol
        {
            get
            {
                return _ShotSymbol;
            }
            set
            {
                _ShotSymbol = value;
            }
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

        public override void Shot()
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

    class Gun2 : Gun
    {
        public Gun2(int count, char symbol)
            : base(count, symbol) // Вызываем конструктор базового класса и передаём ему нужные параметры
        {
            //_AmmoCount = count;
            //_ShotSymbol = symbol;
            Console.WriteLine("\tсоздан второй ствол для ружья");
        }

        public override void Shot()
        {
            for (var i = 0; i < 2; i++)
                if (_AmmoCount > 0)
                {
                    Console.Write(_ShotSymbol);
                    _AmmoCount--;
                }
                else
                {
                    Console.WriteLine("Патроны закончились");
                    return;
                }

            Console.WriteLine();
        }
    }

    class Gun3 : Gun
    {
        public Gun3(int count, char symbol)
            : base(count, symbol) // Вызываем конструктор базового класса и передаём ему нужные параметры
        {
            //_AmmoCount = count;
            //_ShotSymbol = symbol;
            Console.WriteLine("\tсоздан второй и третий ствол для ружья");
        }

        public override void Shot()
        {
            for (var i = 0; i < 3; i++)
                if (_AmmoCount > 0)
                {
                    Console.Write(_ShotSymbol);
                    _AmmoCount--;
                }
                else
                {
                    Console.WriteLine("Патроны закончились");
                    return;
                }

            Console.WriteLine();
        }
    }

    class PistolWithUnlimitedAmmo : Weapon
    {
        public override void Shot()
        {
            Console.WriteLine('-');
        }
    }

    class RifleGunWithUnlimitedAmmo : Weapon
    {
        public override void Shot()
        {
            for (var i = 0; i < 7; i++)
                Console.WriteLine('=');
        }
    }
}
