using System;

namespace monster_killer
{
    public class Vampire : Monster, IFireKills, ISilverKills
    {
        public void Burn (string attack)
        {
            if (attack == "Fire") {
                Console.WriteLine("You just killed the Vampire with Fire");
            }
        }
        public void Stab (string attack)
        {
            if (attack == "Silver") {
                Console.WriteLine("You just killed the Vampire with Silver");
            }
        }
    }
}