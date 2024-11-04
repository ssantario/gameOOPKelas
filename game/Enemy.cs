using System;

namespace game
{
    class Enemy : Entity
    {
        public Enemy(string name, int health, int attackPower) : base(name, health, attackPower) { }

        public override void Attack(Entity character)
        {
            Console.WriteLine($"{name} attacks {character.name} for {attackPower} damage.");
            character.health -= attackPower;
            if (character.health <= 0)
            {
                Console.WriteLine($"{character.name} has been defeated!");
            }
            else
            {
                Console.WriteLine($"{character.name} has {character.health} health remaining.");
            }
        }
    }
}
