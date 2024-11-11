using System;
using System.Collections.Generic;

namespace game
{
    class Inventory
    {
        private List<Item> items;

        public Inventory()
        {
            items = new List<Item>();
        }

        public void AddItem(Item item)
        {
            items.Add(item);
            Console.WriteLine($"\n{item.Name} has been added to the inventory.\n");
        }

        public void UseItem(string itemName, Character character)
        {
            Item item = items.Find(i => i.Name == itemName);
            if (item != null)
            {
                item.Use(character);
                items.Remove(item);
                Console.WriteLine($"\n{item.Name} has been used.\n");
            }
            else
            {
                Console.WriteLine($"\n{itemName} not found in inventory.\n");
            }
        }

        public void ShowInventory()
        {
            Console.WriteLine("Inventory:");
            foreach (var item in items)
            {
                Console.WriteLine($"- {item.Name}\n");
            }
        }
    }
}
