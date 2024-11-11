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
            Console.WriteLine($"{item.Name} has been added to the inventory.");
        }

        public void UseItem(string itemName, Character character)
        {
            Item item = items.Find(i => i.Name == itemName);
            if (item != null)
            {
                item.Use(character);
                items.Remove(item);
                Console.WriteLine($"{item.Name} has been used.");
            }
            else
            {
                Console.WriteLine($"{itemName} not found in inventory.");
            }
        }

        public void ShowInventory()
        {
            Console.WriteLine("Inventory:");
            foreach (var item in items)
            {
                Console.WriteLine($"- {item.Name}");
            }
        }
    }
}