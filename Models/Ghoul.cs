using System;

namespace monster_killer
{
    public class Ghoul : ISilverKills, IWaterKills
    {
        public void Stab (string attack)
        {
            if (attack == "Silver") {
                Console.WriteLine("You just killed the Ghoul with Silver");
            }
        }
        public void Douse (string attack)
        {
            if (attack == "Water") {
                Console.WriteLine("You just killed the Ghoul with Holy Water");
            }
        }
    }
}