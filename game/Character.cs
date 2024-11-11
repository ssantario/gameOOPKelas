using System;

namespace game
{
    public class Character : Entity
    {
        private int level;
        private int exp;
        private int expToNextLevel;
        private Inventory inventory;

        private static Character instance = null!;

        private Character(string name, int health, int attackPower) : base(name, health, attackPower)
        {
            this.level = 1;
            this.exp = 0;
            this.expToNextLevel = 100; // Initial EXP required for level up
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
                GainExp(((Enemy)enemy).expReward);
            }
            else
            {
                Console.WriteLine($"{enemy.name} has {enemy.health} health remaining.\n");
            }
        }

        private void GainExp(int amount)
        {
            exp += amount;
            Console.WriteLine($"{name} gained {amount} EXP.\n");
            CheckLevelUp();
        }

        private void CheckLevelUp()
        {
            while (exp >= expToNextLevel)
            {
                exp -= expToNextLevel;
                LevelUp();
            }
        }

        public void LevelUp()
        {
            level++;
            health += 10;
            attackPower += 5;
            expToNextLevel += 50; // Increase the EXP required for the next level
            Console.WriteLine($"\n!!!!===  {name} leveled up to level {level}  ===!!!!\n\n");
        }
    }
}
