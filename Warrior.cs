using System;

namespace GladiatorFights
{
    class Warrior
    {

        protected int _health { get; set; }
        public int Damage { get; set; }
        protected int _armor { get; set; }
        
        public bool IsFight = true;

        public Warrior(Random random)
        {
            _health = random.Next(100, 151);
            Damage = random.Next(20, 40);
            _armor = random.Next(10, 20);
        }

        public void TakeDamage(int damage)
        {
            _health -= damage - _armor;
            if (_health <= 0)
            {
                IsFight = false;
            }
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Здровье: {_health}, броня: {_armor}, урон: {Damage}");
        }

        public void Superpower(Knight knight, Barbarian barbarian, Magician magician, Alchemist alchemist, Churcher churcher)
        {
            knight.Superpower();
            barbarian.Superpower();
            magician.Superpower();
            alchemist.Superpower();
            churcher.Superpower();
        }

        public int BreakProtection()
        {
            return _armor;
        }

    }
}
