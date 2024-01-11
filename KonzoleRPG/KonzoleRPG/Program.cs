using System;

namespace ConsoleRPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Console RPG!");
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
                        Console.WriteLine("Exiting game...");
                        gameOver = true;
                        break;
                    default:
                        Console.WriteLine("Invalid input. Try again.");
                        break;
                }
            }

            Console.WriteLine("Thanks for playing Console RPG!");
        }

        static Player CreatePlayer()
        {
            Console.WriteLine("Enter your hero's name: ");
            string playerName = Console.ReadLine();
            Player player = new Player(playerName, 100, 10, 1, 0, 100);
            Console.WriteLine($"Welcome, {playerName}!");

            return player;
        }

        static void DisplayMainMenu()
        {
            Console.WriteLine("\nMain Menu:");
            Console.WriteLine("1. Explore");
            Console.WriteLine("2. Show Player Status");
            Console.WriteLine("3. Exit");
            Console.Write("Choose an action: ");
        }

        static void Explore(Player player)
        {
            Random random = new Random();
            int encounterChance = random.Next(1, 11); // Random chance of encounter

            if (encounterChance <= 7) // 70% chance of an encounter
            {
                Enemy enemy = EnemyFactory.CreateRandomEnemy();
                Console.WriteLine($"You've encountered a {enemy.Name}!");

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
                                Console.WriteLine($"You defeated the {enemy.Name}!");
                                player.GainExperience(enemy.ExperiencePoints);
                                battleOver = true;
                            }
                            else
                            {
                                enemy.Attack(player);
                                if (player.IsDead())
                                {
                                    Console.WriteLine("You were defeated!");
                                    battleOver = true;
                                }
                            }
                            break;
                        case "2":
                            Console.WriteLine("Running away...");
                            battleOver = true;
                            break;
                        default:
                            Console.WriteLine("Invalid input. Try again.");
                            break;
                    }
                }
            }
            else
            {
                Console.WriteLine("You explored but found nothing.");
            }
        }

        static void DisplayBattleOptions()
        {
            Console.WriteLine("\nBattle Options:");
            Console.WriteLine("1. Attack");
            Console.WriteLine("2. Run Away");
            Console.Write("Choose an action: ");
        }

        static void ShowPlayerStatus(Player player)
        {
            Console.WriteLine($"\nPlayer Status:");
            Console.WriteLine($"Name: {player.Name}");
            Console.WriteLine($"Health: {player.Health}");
            Console.WriteLine($"Damage: {player.Damage}");
            Console.WriteLine($"Level: {player.Level}");
            Console.WriteLine($"Experience: {player.Experience}/{player.ExperienceToLevelUp}");
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
            int damageDealt = new Random().Next(1, Damage + 1); // Calculate random damage within player's damage range
            enemy.Health -= damageDealt;
            Console.WriteLine($"You attacked {enemy.Name} for {damageDealt} damage!");
        }

        public void GainExperience(int points)
        {
            Experience += points;
            Console.WriteLine($"You gained {points} experience!");
            if (Experience >= ExperienceToLevelUp)
            {
                LevelUp();
            }
        }

        private void LevelUp()
        {
            Level++;
            Console.WriteLine($"Congratulations! You reached Level {Level}!");

            // Increase stats or add new abilities upon leveling up
            Health += 20;
            Damage += 5;

            // Reset experience and set a higher threshold for next level
            Experience -= ExperienceToLevelUp;
            ExperienceToLevelUp = (int)(ExperienceToLevelUp * 1.5);
        }

        public bool IsDead()
        {
            return Health <= 0;
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
            int damageDealt = new Random().Next(1, Damage + 1); // Calculate random damage within enemy's damage range
            player.Health -= damageDealt;
            Console.WriteLine($"{Name} attacked you for {damageDealt} damage!");
        }

        public bool IsDead()
        {
            return Health <= 0;
        }
    }

    static class EnemyFactory
    {
        private static readonly string[] EnemyTypes = { "Goblin", "Skeleton", "Orc", "Dragon" };
        private static readonly Random Random = new Random();

        public static Enemy CreateRandomEnemy()
        {
            string enemyType = EnemyTypes[Random.Next(EnemyTypes.Length)]; // Get a random enemy type from the list
            int enemyHealth = Random.Next(30, 101); // Random health between 30 and 100
            int enemyDamage = Random.Next(5, 21); // Random damage between 5 and 20
            int enemyExperience = (int)Math.Round((double)(enemyHealth + enemyDamage) / 2); // Calculate experience based on enemy stats

            return new Enemy(enemyType, enemyHealth, enemyDamage, enemyExperience);
        }
    }
}
