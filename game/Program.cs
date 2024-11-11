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

            hero.Attack(orcWarrior);
            orcWarrior.Attack(hero);
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