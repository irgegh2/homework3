using System;

namespace RPGGame
{
    public class Unit
    {
        private float health;

        public string Name { get; }
        public float Health { get { return health; } }
        public Interval Damage { get; }
        public float Armor { get; }

        public Unit() : this("Unknown Unit")
        {
        }

        public Unit(string name)
        {
            Name = name;
            health = 100f;
            Damage = new Interval(0, 5);
            Armor = 0.6f;
        }

        public Unit(string name, int minDamage, int maxDamage)
        {
            Name = name;
            health = 100f;
            Damage = new Interval(minDamage, maxDamage);
            Armor = 0.6f;
        }

        public float GetRealHealth()
        {
            return Health * (1f + Armor);
        }

        public bool SetDamage(float value)
        {
            health -= value * Armor;
            
            return health <= 0f;
        }

        public override string ToString()
        {
            return $"{Name} (HP: {Health:F1}, Damage: {Damage.Min}-{Damage.Max}, Armor: {Armor})";
        }
    }
}
