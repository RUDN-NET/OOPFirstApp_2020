using System;

namespace OOPFirstApp.Weapons
{
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
}