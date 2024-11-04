package game;

class Enemy extends Entity {
    public Enemy(String name, int health, int attackPower) {
        super(name, health, attackPower);
    }

    @Override
    public void attack(Entity character) {
        System.out.println(name + " attacks " + character.name + " for " + attackPower + " damage.");
        character.health -= attackPower;
        if (character.health <= 0) {
            System.out.println(character.name + " has been defeated!");
        } else {
            System.out.println(character.name + " has " + character.health + " health remaining.");
        }
    }
}
