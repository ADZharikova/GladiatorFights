using System;

namespace GladiatorFights
{
    internal class Alchemist : Warrior
    {
        private int _moveCounter = 0;
        public Alchemist(Random random) : base(random)
        {

        }
        public void Superpower()
        {
            if (_moveCounter == 3)
            {
                _armor *= 2;
            }
            _moveCounter++;
        }
    }
}
