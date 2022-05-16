using System;

namespace GladiatorFights
{
    internal class Knight : Warrior
    {
        public Knight(Random random) : base(random)
        {

        }

        public void Superpower()
        {
            if (_health < 70)
            {
                _health += 7;
            }
        }
    }
}
