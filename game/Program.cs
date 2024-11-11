﻿using System;

namespace game
{
    public class GameApp
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

            Enemy dragonWarrior = EnemyFactory.CreateEnemy("Dragon", "Ice");

            hero.Attack(orcWarrior);
            orcWarrior.Attack(hero);

            hero.Attack(orcWarrior);
            orcWarrior.Attack(hero);

            hero.Attack(orcWarrior);
            orcWarrior.Attack(hero);

            hero.Attack(orcWarrior);
            orcWarrior.Attack(hero);

            hero.Attack(orcWarrior);
            orcWarrior.Attack(hero);

            inventory.UseItem("Health Potion", hero);
            hero.Attack(orcWarrior);
            orcWarrior.Attack(hero);

            hero.Attack(orcWarrior);
            dragonWarrior.Attack(hero);
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
            !!!+++++++++++++++++++++ Game Start +++++++++++++++++++++!!!
            ");
        }
    }
}
