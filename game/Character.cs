using System;

namespace game
{
    class Character : Entity
    {
        private int level;
        private Inventory inventory;

        private static Character instance;

        private Character(string name, int health, int attackPower) : base(name, health, attackPower)
        {
            this.level = 1;
            this.inventory = new Inventory();
        }

        public static Character GetInstance(string name, int health, int attackPower)
        {
            if (instance == null)
            {
                instance = new Character(name, health, attackPower);
            }
            return instance;
        }

        public override void Attack(Entity enemy)
        {
            Console.WriteLine($"{name} attacks {enemy.name} for {attackPower} damage.");
            enemy.health -= attackPower;
            if (enemy.health <= 0)
            {
                Console.WriteLine($"{enemy.name} has been defeated!");
            }
            else
            {
                Console.WriteLine($"{enemy.name} has {enemy.health} health remaining.");
            }
        }

        public void LevelUp()
        {
            level++;
            health += 10;
            attackPower += 5;
            Console.WriteLine($"{name} leveled up to level {level}!");
        }
    }
}
