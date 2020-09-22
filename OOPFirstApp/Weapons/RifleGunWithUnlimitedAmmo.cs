using System;

namespace OOPFirstApp.Weapons
{
    class RifleGunWithUnlimitedAmmo : Weapon
    {
        public override void Shot()
        {
            for (var i = 0; i < 7; i++)
                Console.WriteLine('=');
        }
    }
}