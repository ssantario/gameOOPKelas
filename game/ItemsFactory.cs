using System;

namespace game
{
    class ItemsFactory
    {
        public static Item CreateItem(string type)
        {
            switch (type)
            {
                case "HealthPotion":
                    return new Item("Health Potion", character => character.Heal(50));
                case "DamagePotion":
                    return new Item("Damage Potion", character => character.IncreaseDamage(1.5));
                default:
                    throw new ArgumentException("Invalid item type");
            }
        }
    }
}