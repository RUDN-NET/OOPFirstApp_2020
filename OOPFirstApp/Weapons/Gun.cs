using System;

namespace OOPFirstApp.Weapons
{
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
}