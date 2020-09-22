using System;

namespace OOPFirstApp.Weapons
{
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
}