using System;

namespace monster_killer
{
    public class Ghast : Monster, IFireKills, IWaterKills
    {
        public void Burn (string attack)
        {
            if (attack == "Fire") {
                Console.WriteLine("You just killed the Ghast with Fire");
            }
        }
        public void Douse (string attack)
        {
            if (attack == "Water") {
                Console.WriteLine("You just killed the Ghast with Holy Water");
            }
        }
    }
}