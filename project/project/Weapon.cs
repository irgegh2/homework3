using System;

namespace RPGGame
{
    public class Weapon
    {
        public string Name { get; }
        public Interval Damage { get; private set; }
        public float Durability { get; }

        public Weapon(string name)
        {
            Name = name;
            Durability = 1f;
            Damage = new Interval(1, 10);
        }

        public Weapon(string name, int minDamage, int maxDamage)
        {
            Name = name;
            Durability = 1f;
            Damage = new Interval(minDamage, maxDamage);
        }

        public void SetDamageParams(int minDamage, int maxDamage)
        {
            Damage = new Interval(minDamage, maxDamage);
        }

        public int GetDamage()
        {
            return (Damage.Min + Damage.Max) / 2;
        }

        public override string ToString()
        {
            return $"{Name} (Damage: {Damage.Min}-{Damage.Max}, Durability: {Durability})";
        }
    }
}
