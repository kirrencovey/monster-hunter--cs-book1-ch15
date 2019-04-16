using System;

namespace monster_killer
{
    public class Monster
    {
        public void Kill (string attack)
        {
            if (attack == "Silly Putty") {
                Console.WriteLine("You just killed the monster with the most powerful weapon in the universe, Silly Putty!");
            }
        }
    }
}