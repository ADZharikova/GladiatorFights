using System;

namespace GladiatorFights
{
    internal class Magician : Warrior
    {
        private int _moveCounter = 0;
        public Magician(Random random) : base(random)
        {

        }

        public void Superpower()
        {
            if (_moveCounter == 3)
            {
                Damage += 30;
            }
            if (_moveCounter == 4)
            {
                Damage -= 30;
            }
            _moveCounter++;
        }
    }
}
