namespace game
{
    public class Entity
    {
        public string name;
        public int health;
        public int attackPower;

        public Entity(string name, int health, int attackPower)
        {
            this.name = name;
            this.health = health;
            this.attackPower = attackPower;
        }

        public virtual void Attack(Entity target)
        {
            // Default attack behavior (if any)
        }
    }
}
