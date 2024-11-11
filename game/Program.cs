using System;

namespace game
{
    public class game
    {
        public static void Main(string[] args)
        {
            Character hero = Character.GetInstance("Hero", 100, 15);
            Enemy goblin = EnemyFactory.CreateEnemy("Goblin");

            hero.Attack(goblin);
            goblin.Attack(hero);
        }
    }
}