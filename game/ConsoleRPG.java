package game;

class Inventory {
    // Implementation of inventory system
}

public class ConsoleRPG {
    public static void main(String[] args) {
        Character hero = Character.getInstance("Hero", 100, 15);
        Enemy goblin = EnemyFactory.createEnemy("Goblin");

        hero.attack(goblin);
        goblin.attack(hero);
    }
}