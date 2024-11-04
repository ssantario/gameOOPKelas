package game;

class Character extends Entity {
    private int level;
    private Inventory inventory;

    private static Character instance;

    private Character(String name, int health, int attackPower) {
        super(name, health, attackPower);
        this.level = 1;
        this.inventory = new Inventory();
    }

    public static Character getInstance(String name, int health, int attackPower) {
        if (instance == null) {
            instance = new Character(name, health, attackPower);
        }
        return instance;
    }

    @Override
    public void attack(Entity enemy) {
        System.out.println(name + " attacks " + enemy.name + " for " + attackPower + " damage.");
        enemy.health -= attackPower;
        if (enemy.health <= 0) {
            System.out.println(enemy.name + " has been defeated!");
        } else {
            System.out.println(enemy.name + " has " + enemy.health + " health remaining.");
        }
    }

    public void levelUp() {
        level++;
        health += 10;
        attackPower += 5;
        System.out.println(name + " leveled up to level " + level + "!");
    }
}