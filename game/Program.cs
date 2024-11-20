using System;
using System.Transactions;

namespace game
{
    public class GameApp
    {
        public static void Main(string[] args)
        {
            ShowMainMenu();

            Character hero = Character.GetInstance("Hero", 100, 15);
            Enemy goblin = EnemyFactory.CreateEnemy("Goblin", "");
            Enemy orcWarrior = EnemyFactory.CreateEnemy("Orc", "Warrior");
            Enemy finalBoss = EnemyFactory.CreateEnemy("Dragon", "Ice");

            Inventory inventory = new Inventory();

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

            Item healthPotion = ItemsFactory.CreateItem("HealthPotion");
            Item damagePotion = ItemsFactory.CreateItem("DamagePotion");
            inventory.AddItem(healthPotion);
            inventory.AddItem(damagePotion);
            inventory.ShowInventory();
            hero.showStats();

            PlayLevel(hero, goblin, inventory, "[Level 1]: Fight the Goblin!\n");
            if (hero.health > 0)
            {
                PlayLevel(hero, orcWarrior, inventory, "[Level 2]: Fight the Orc Warrior!\n");
            }
            if (hero.health > 0)
            {
                PlayLevel(hero, finalBoss, inventory, "[Final Level]: Fight the Dragon!\n");
            }

            if (hero.health > 0)
            {
                Console.WriteLine("Congratulations! You have defeated all the enemies!");
            }
            else
            {
                Console.WriteLine("Game Over. You have been defeated.");
            }
        }

        private static void PlayLevel(Character hero, Enemy enemy, Inventory inventory, string levelMessage)
        {
            Console.Clear();
            ShowMainMenu();
            Console.WriteLine(levelMessage);

            while (hero.health > 0 && enemy.health > 0)
            {
                Console.WriteLine("Choose an action:");
                Console.WriteLine("1. Attack");
                Console.WriteLine("2. Defend");
                Console.WriteLine("3. Use item");
                Console.Write("Enter choice: ");
                string choice = Console.ReadLine();

                Console.Clear();
                ShowMainMenu();
                Console.WriteLine(levelMessage);

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("==Battle Zone==\n");
                        hero.Attack(enemy);
                        break;
                    case "2":
                        Console.WriteLine("==Battle Zone==\n");
                        hero.Defend();
                        break;
                    case "3":
                        inventory.ShowInventory();
                        Console.Write("Enter item name: ");
                        string itemName = Console.ReadLine();
                        inventory.UseItem(itemName, hero);
                        hero.showStats();
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        Console.Clear();
                        ShowMainMenu();
                        Console.WriteLine(levelMessage);
                        Console.WriteLine("==Battle Zone==\n");
                        break;
                    default:
                        Console.WriteLine("[!] Invalid choice.\n");
                        continue;
                }

                if (enemy.health > 0)
                {
                    enemy.Attack(hero);
                }

                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                Console.Clear();
                ShowMainMenu();
                Console.WriteLine(levelMessage);
            }
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
                                                                    -_- 
            !!!+++++++++++++++++++++ Game Start +++++++++++++++++++++!!!");
        }
    }
}
