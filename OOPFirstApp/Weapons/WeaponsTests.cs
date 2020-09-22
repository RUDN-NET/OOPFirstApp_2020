namespace OOPFirstApp.Weapons
{
    class WeaponsTests
    {
        public static void Start()
        {
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
        }

        static void ShotFromWeapon(Weapon weapon, int count = 7)
        {
            for (var i = 0; i < count; i++)
                weapon.Shot();
        }
    }
}
