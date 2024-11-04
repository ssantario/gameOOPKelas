package game;

abstract class Entity {
    protected String name;
    protected int health;
    protected int attackPower;

    public Entity(String name, int health, int attackPower) {
        this.name = name;
        this.health = health;
        this.attackPower = attackPower;
    }

    public abstract void attack(Entity target);
}