using System;

namespace game
{
    class Enemy : Entity
    {
        public int expReward;

        public Enemy(string name, int health, int attackPower, int expReward) : base(name, health, attackPower)
        {
            this.expReward = expReward;
        }

        public override void Attack(Entity character)
        {
            Console.WriteLine($"{name} attacks {character.name} for {attackPower} damage.");
            character.health -= attackPower;
            if (character.health <= 0)
            {
                Console.WriteLine($"{character.name} has been defeated!\n");
            }
            else
            {
                Console.WriteLine($"{character.name} has {character.health} health remaining.\n");
            }
        }
    }
}
