namespace game
{
    public class Enemy : Entity
    {
        public int ExpValue { get; }
        public Enemy(string name, int health, int attackPower, int expValue)
            : base(name, health, attackPower)
        {
            ExpValue = expValue;
        }

        public void TakeDamage(int damage)
        {
            health -= damage;
            
            if (health < 0)
            {
                health = 0;
            }
            
            Console.WriteLine($"{name} takes {damage} damage.");
            Console.WriteLine($"{name} health: {health}\n");
        }

        public override void Attack(Entity target)
        {
            if (target is Character character)
            {
                Console.WriteLine($"{name} attacks {character.name} for {attackPower} damage.");
                character.TakeDamage(attackPower);
            }
        }
    }
}
