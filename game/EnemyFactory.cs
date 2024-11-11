namespace game
{
    class EnemyFactory
    {
        public static Enemy CreateEnemy(string type, string variation)
        {
            switch (type)
            {
                case "Goblin":
                    return new Enemy("Goblin", 30, 5);
                case "Orc":
                    switch (variation)
                    {
                        case "Warrior":
                            return new Enemy("Orc Warrior", 60, 15);
                        case "Shaman":
                            return new Enemy("Orc Shaman", 40, 20);
                        default:
                            return new Enemy("Orc", 50, 10);
                    }
                case "Dragon":
                    switch (variation)
                    {
                        case "Fire":
                            return new Enemy("Fire Dragon", 120, 40);
                        case "Ice":
                            return new Enemy("Ice Dragon", 110, 35);
                        default:
                            return new Enemy("Dragon", 100, 30);
                    }
                default:
                    return new Enemy("Unknown", 1, 1);
            }
        }
    }
}
