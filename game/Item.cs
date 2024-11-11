namespace game
{
    public class Item
    {
        public string Name { get; set; }

        public Item(string name)
        {
            Name = name;
        }

        public void Use(Character character)
        {
            Console.WriteLine($"{Name} digunakan pada {character.name}.");
        }
    }
}
