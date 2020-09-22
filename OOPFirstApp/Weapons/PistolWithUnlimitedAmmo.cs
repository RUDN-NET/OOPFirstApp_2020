using System;

namespace OOPFirstApp.Weapons
{
    class PistolWithUnlimitedAmmo : Weapon
    {
        public override void Shot()
        {
            Console.WriteLine('-');
        }
    }
}