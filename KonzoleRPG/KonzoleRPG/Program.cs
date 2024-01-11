using System;
using System.Diagnostics;

namespace ConsoleRPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Právě hraješ konzolové RPG!");
            Player player = CreatePlayer();

            bool gameOver = false;
            while (!gameOver)
            {
                DisplayMainMenu();
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Explore(player);
                        break;
                    case "2":
                        ShowPlayerStatus(player);
                        break;
                    case "3":
                        Console.WriteLine("Ukončuji...");
                        gameOver = true;
                        break;
                    default:
                        Console.WriteLine("Tohle tu nefunguje(vybíráš pomocí: 1, 2, 3). Zkus to znovu.");
                        break;
                }
            }

            Console.WriteLine("Měj se!");
        }

        static Player CreatePlayer()
        {
            Console.WriteLine("A jakpak se jmenuješ? ");
            string playerName = Console.ReadLine();
            Player player = new Player(playerName, 100, 10, 1, 0, 100);
            Console.WriteLine($"Vítej, {playerName}!");

            return player;
        }

        static void DisplayMainMenu()
        {
            Console.WriteLine("\nMain Menu:");
            Console.WriteLine("1. Jdeme prozkoumávat");
            Console.WriteLine("2. Jak to se mnou vypadá?");
            Console.WriteLine("3. Zpět");
            Console.Write("Kterou akci chceš provést?");
        }
        
        static void Explore(Player player)
        {
            Random random = new Random();
            int encounterChance = random.Next(1, 11); 

            if (encounterChance <= 7)
            {
                Enemy enemy = EnemyFactory.CreateRandomEnemy();
                Console.WriteLine($"Narazil jsi na {enemy.Name}!");

                bool battleOver = false;
                while (!battleOver)
                {
                    DisplayBattleOptions();
                    string input = Console.ReadLine();

                    switch (input)
                    {
                        case "1":
                            player.Attack(enemy);
                            if (enemy.IsDead())
                            {
                                Console.WriteLine($"Porazil jsi: {enemy.Name}!");
                                player.GainExperience(enemy.ExperiencePoints);
                                battleOver = true;
                            }
                            else
                            {
                                enemy.Attack(player);
                                if (player.IsDead())
                                {
                                    Console.WriteLine("Byl jsi poražen!");
                                    battleOver = true;
                                }
                            }
                            break;
                        case "2":
                            Console.WriteLine("Útěk...");
                            battleOver = true;
                            break;
                        default:
                            Console.WriteLine("Tohle tu nefunguje(vybíráš pomocí: 1, 2, 3). Zkus to znovu.");
                            break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Jaj, nic jsi nenašel.");
            }
        }

        static void DisplayBattleOptions()
        {
            Console.WriteLine("\nCopak uděláš?");
            Console.WriteLine("1. Útooook");
            Console.WriteLine("2. Uteču(bojím se)");
            Console.Write("Vybírej opatrně: ");
        }

        static void ShowPlayerStatus(Player player)
        {
            Console.WriteLine($"\nTakhle na tom jsi:");
            Console.WriteLine($"Jméno: {player.Name}");
            Console.WriteLine($"Životy: {player.Health}");
            Console.WriteLine($"Poškození: {player.Damage}");
            Console.WriteLine($"Level: {player.Level}");
            Console.WriteLine($"Zkušenosti: {player.Experience}/{player.ExperienceToLevelUp}");
        }
    }

    class Player
    {
        public string Name { get; }
        public int Health { get; set; }
        private int damage;

        public int Damage
        {
            get => damage;
            private set => damage = value;
        }
        public int Level { get; private set; }
        public int Experience { get; private set; }
        public int ExperienceToLevelUp { get; private set; }

        public Player(string name, int health, int damage, int level, int experience, int experienceToLevelUp)
        {
            Name = name;
            Health = health;
            Damage = damage;
            Level = level;
            Experience = experience;
            ExperienceToLevelUp = experienceToLevelUp;
        }

        public void Attack(Enemy enemy)
        {
            int damageDealt = new Random().Next(1, Damage + 1); 
            enemy.Health -= damageDealt;
            Console.WriteLine($"Zaútočil jsi na {enemy.Name} a dal jsi {damageDealt} Poškození!");
        }

        public void GainExperience(int points)
        {
            Experience += points;
            Console.WriteLine($"Získal jsi {points} zkušeností!");
            if (Experience >= ExperienceToLevelUp)
            {
                LevelUp();
            }
        }

        private void LevelUp()
        {
            Level++;
            Console.WriteLine($"Level up! Dosáhl jsi levelu {Level}!");

            
            Health += 20;
            Damage += 5;

            
            Experience -= ExperienceToLevelUp;
            ExperienceToLevelUp = (int)(ExperienceToLevelUp * 1.5);
        }

        public bool IsDead()
        {
            return Health <= 0;
        }
    }
    class Place
    {
        public string Name { get; }
        public string Buff { get; set; }

        public Place(string name, string buff)
        {
            Name = name;
            Buff = buff;
        }

        

        
    }
    static class Places
    {

        private static readonly string[] Types = { "Město", "Vesnice", "Les", "Louka", };
        private static readonly string[] Buffs = { "Město", "Vesnice", "Les", "Louka", };
        private static readonly Random Random = new Random();

        public static Place ChoosePlace()
        {
            string placeType = Types[Random.Next(Types.Length)];
            string placeBuff = Buffs[Random.Next(Buffs.Length)];

            return new Place(placeType, placeBuff);
        }
    }
    class Enemy
    {
        public string Name { get; }
        public int Health { get; set; }
        public int Damage { get; }
        public int ExperiencePoints { get; }

        public Enemy(string name, int health, int damage, int experiencePoints)
        {
            Name = name;
            Health = health;
            Damage = damage;
            ExperiencePoints = experiencePoints;
        }

        public void Attack(Player player)
        {
            int damageDealt = new Random().Next(1, Damage + 1);
            player.Health -= damageDealt;
            Console.WriteLine($"{Name} na tebe zaútočil a udělil {damageDealt} poškození!");
        }

        public bool IsDead()
        {
            return Health <= 0;
        }
    }
    
    static class EnemyFactory
    {
        private static readonly string[] EnemyTypes = { "Goblin", "Kostlivec", "Ork", "Drak", "Zombie" };
        private static readonly Random Random = new Random();

        public static Enemy CreateRandomEnemy()
        {
            string enemyType = EnemyTypes[Random.Next(EnemyTypes.Length)];
            int enemyHealth = Random.Next(30, 101);
            int enemyDamage = Random.Next(5, 21);
            int enemyExperience = (int)Math.Round((double)(enemyHealth + enemyDamage) / 2);

            return new Enemy(enemyType, enemyHealth, enemyDamage, enemyExperience);
        }
    }
}
