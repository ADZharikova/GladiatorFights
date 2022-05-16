using System;

namespace GladiatorFights
{
    internal class Barbarian : Warrior
    {
        private int _moveCounter = 0;
        public Barbarian(Random random) : base(random)
        {
            _health = random.Next(80, 120);
        }
        public void Superpower()
        {
            if (_moveCounter == 3)
            {
                Damage *= 2;
            }
            _moveCounter++;
        }
    }
}
