using System;

namespace monster_killer
{
    public class Wight : Monster, ISilverKills
    {
        public void Stab (string attack)
        {
            if (attack == "Silver") {
                Console.WriteLine("You just killed the Wight with Silver");
            }
        }
    }
}