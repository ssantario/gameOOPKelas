namespace game
{
    abstract class Entity
    {
        protected string name;
        protected int health;
        protected int attackPower;

        protected Entity(string name, int health, int attackPower)
        {
            this.name = name;
            this.health = health;
            this.attackPower = attackPower;
        }

        public abstract void Attack(Entity target);
    }
}
