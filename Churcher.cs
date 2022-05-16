using System;

namespace GladiatorFights
{
    internal class Churcher : Warrior
    {
        private int j = 0;
        public Churcher(Random random) : base(random)
        {

        }

        public void Superpower()
        {
            if (_health < 50 && j == 0)
            {
                _health += 70;
                j = 1;
            }
        }
    }
}
