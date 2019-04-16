using System;
using System.Collections.Generic;

namespace monster_killer
{
    class Program
    {
        public static void Main()
        {
            Hunter VonRimmersmark = new Hunter("Erich", "Von Rimmersmark");

            Console.WriteLine(VonRimmersmark.ToString());

            Mummy tuts = new Mummy();
            Vampire drac = new Vampire();
            Demon todd = new Demon();
            Zombie fred = new Zombie();
            Ghoul gary = new Ghoul();
            Ghast lou = new Ghast();
            Wight jim = new Wight();

            VonRimmersmark.Ignite(tuts);
            VonRimmersmark.WieldSilver(drac);
            VonRimmersmark.SplashWater(todd);
            VonRimmersmark.WieldSillyPutty(fred);
            VonRimmersmark.SplashWater(gary);
            VonRimmersmark.WieldSillyPutty(lou);
            VonRimmersmark.WieldSilver(jim);

        }
    }
}
