using System;

namespace monster_killer
{
    public class Demon : Monster, IFireKills, ISilverKills, IWaterKills
    {
        public void Burn (string attack)
        {
            if (attack == "Fire") {
                Console.WriteLine("You just killed the Demon with Fire");
            }
        }
        public void Stab (string attack)
        {
            if (attack == "Silver") {
                Console.WriteLine("You just killed the Demon with Silver");
            }
        }
        public void Douse (string attack)
        {
            if (attack == "Water") {
                Console.WriteLine("You just killed the Demon with Holy Water");
            }
        }
    }
}