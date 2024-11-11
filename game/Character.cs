using System;

namespace game
{
    class Character
    {
        public string Name { get; }
        public int Health { get; private set; }
        public int Attack { get; private set; }

        private static Character instance;

        private Character(string name, int health, int attack)
        {
            Name = name;
            Health = health;
            Attack = attack;
        }

        public static Character GetInstance(string name, int health, int attack)
        {
            if (instance == null)
            {
                instance = new Character(name, health, attack);
            }
            return instance;
        }

        public void Heal(int amount)
        {
            Health += amount;
            Console.WriteLine($"{Name} healed by {amount}. Current health: {Health}");
        }

        public void IncreaseDamage(double multiplier)
        {
            Attack = (int)(Attack * multiplier);
            Console.WriteLine($"{Name}'s attack increased to {Attack}.");
        }

        public void AttackEnemy(Enemy enemy)
        {
            enemy.TakeDamage(Attack);
            Console.WriteLine($"{Name} attacks {enemy.Name} for {Attack} damage.");
        }
    }
}