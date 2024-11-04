namespace game
{
    class EnemyFactory
    {
        public static Enemy CreateEnemy(string type)
        {
            switch (type)
            {
                case "Goblin":
                    return new Enemy("Goblin", 30, 5);
                case "Orc":
                    return new Enemy("Orc", 50, 10);
                case "Dragon":
                    return new Enemy("Dragon", 100, 30);
                default:
                    return new Enemy("Unknown", 1, 1);
            }
        }
    }
}
