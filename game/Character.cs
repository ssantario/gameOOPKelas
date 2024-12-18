namespace game
{
    public class Character : Entity
    {
        private static Character instance = null!;
        public int Level { get; private set; }
        public int Exp { get; private set; }
        public int ExpToNextLevel { get; private set; }

        bool isDefending = false;

        private Character(string name, int health, int attackPower)
            : base(name, health, attackPower)
        {
            Level = 1;
            Exp = 0;
            ExpToNextLevel = 100;
        }

        public static Character GetInstance(string name, int health, int attackPower)
        {
            if (instance == null)
            {
                instance = new Character(name, health, attackPower);
            }
            return instance;
        }

        public void Heal(int amount)
        {
            health += amount;
            Console.WriteLine($"\n{name} healed by {amount}.");
            Console.WriteLine($"\n{name} Current health: {health}");
        }

        public void TakeDamage(int damage)
        {
            if (isDefending)
            {
                damage = (int)(damage * 0.5);
                isDefending = false;
            }
            health -= damage;

            if (health < 0)
            {
                health = 0;
            }
            
            Console.WriteLine($"{name} takes {damage} damage.");
            Console.WriteLine($"{name} health: {health}\n");
        }

        public void IncreaseDamage(double multiplier)
        {
            attackPower = (int)(attackPower * multiplier);
            Console.WriteLine($"\n{name}'s attack increased to {attackPower}.\n");
        }

        public override void Attack(Entity target)
        {
            if (target is Enemy enemy)
            {
                Console.WriteLine($"{name} attacks {enemy.name} for {attackPower} damage.");
                enemy.TakeDamage(attackPower);
                if (enemy.health <= 0)
                {
                    GainExp(enemy.ExpValue);
                }
            }
        }

        private void GainExp(int amount)
        {
            Exp += amount;
            Console.WriteLine($"{name} gains {amount} exp. Current exp: {Exp}/{ExpToNextLevel}\n");

            if (Exp >= ExpToNextLevel)
            {
                LevelUp();
            }
        }
        private void LevelUp()
        {
            Level++;
            Exp -= ExpToNextLevel;
            ExpToNextLevel = (int)(ExpToNextLevel * 1.5); 
            health += 20; 
            attackPower += 5; 
            Console.WriteLine($"{name} leveled up! Current level: {Level}, health: {health}, attack power: {attackPower}\n");
        }


        public void Defend()
        {
            isDefending = true;
        }

        public void showStats()
        {
            Console.WriteLine($"\n{name} - Level: {Level}, Health: {health}, Attack Power: {attackPower}, Exp: {Exp}/{ExpToNextLevel}\n");
        }
    }
}

