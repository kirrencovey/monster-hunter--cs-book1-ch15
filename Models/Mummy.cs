using System;

namespace monster_killer
{
    public class Mummy : IFireKills
    {
        public void Burn (string attack)
        {
            if (attack == "Fire") {
                Console.WriteLine("You just killed the Mummy with Fire");
            }
        }
    }
}