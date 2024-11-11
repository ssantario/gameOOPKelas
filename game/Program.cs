using System;

namespace game
{
    public class game
    {
        public static void Main(string[] args)
        {
            ShowMainMenu();

            Character hero = Character.GetInstance("Hero", 100, 15);
            Enemy orcWarrior = EnemyFactory.CreateEnemy("Orc", "Warrior");
            Inventory inventory = new Inventory();
            Item healthPotion = ItemsFactory.CreateItem("HealthPotion");
            inventory.AddItem(healthPotion);
            inventory.ShowInventory();

            hero.Attack(orcWarrior);
            orcWarrior.Attack(hero);

            inventory.UseItem("Health Potion", hero);
            hero.Attack(orcWarrior);
            orcWarrior.Attack(hero);
        }

        private static void ShowMainMenu()
        {
            Console.WriteLine(@"-_-/        ,, ,,                                 ,         
            (_ /         || ||                 '         _    ||         
            (_ --_   /'\\ || || \\ \\ \\/\\/\\ \\ \\/\\  < \, =||= '\\/\\ 
            --_ ) || || || || || || || || || || || ||  /-||  ||   || ;' 
            _/  )) || || || || || || || || || || || || (( ||  ||   ||/   
            (_-_-   \\,/  \\ \\ \\/\\ \\ \\ \\ \\ \\ \\  \/\\  \\,  |/    
                                                                (      
                                                                    -_- ");
        }
    }
}