namespace game
   
class Item
{
    public string Name { get; }
    public Action<Character> Use { get; }
    public Item(string name, Action<Character> use)
    {
        Name = name;
        Use = use;
    }
}