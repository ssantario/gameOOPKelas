namespace game
{
    public class Character : Entity
    {
        private static Character instance = null!;
        public int Level { get; private set; }
        public int Exp { get; private set; }
        public int ExpToNextLevel { get; private set; }

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
            Console.WriteLine($"{name} healed by {amount}.");
            Console.WriteLine($"{name} Current health: {health}");
        }

         public void TakeDamage(int damage)
        {
            health -= damage;
            Console.WriteLine($"{name} takes {damage} damage.");
            Console.WriteLine($"{name} health: {health}\n");
        }

        public void IncreaseDamage(double multiplier)
        {
            int AttackPower = (int)(attackPower * multiplier);
            Console.WriteLine($"\n{name}'s attack increased to {AttackPower}.\n");
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
            ExpToNextLevel = (int)(ExpToNextLevel * 1.5); // Example formula for increasing exp needed
            health += 20; // Example value for health increase
            attackPower += 5; // Example value for attack power increase
            Console.WriteLine($"{name} leveled up! Current level: {Level}, health: {health}, attack power: {attackPower}\n");
        }
    }
}
