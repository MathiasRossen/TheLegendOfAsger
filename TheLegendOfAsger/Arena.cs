using System;
using GameLogic;

namespace TheLegendOfAsger
{
    class Arena
    {
        ICreature[] enemyList = new ICreature[]
        {
            new Enemy("Street dog", 5, 5, 1),
            new Enemy("Local drunk", 6, 6, 1),
            new Enemy("Weak, sick, handicapped and wounded Goblin", 7, 7, 2)
        };

        ICreature enemy;

        public void ArenaLoop(Player player)
        {
            bool running = true;
            string input;

            do
            {
                Console.Clear();
                DisplayStats(player);
                DisplayChoices();

                input = Console.ReadLine();

                switch (input.ToLower())
                {
                    case "1":
                        enemy = enemyList[0];
                        BattleArena(player, enemy);
                        break;
                    case "2":
                        enemy = enemyList[1];
                        BattleArena(player, enemy);
                        break;
                    case "3":
                        enemy = enemyList[2];
                        BattleArena(player, enemy);
                        break;
                    case "e":
                        running = false;
                        break;
                    default:
                        Game.DisplayInputError();
                        break;
                }
            }
            while (running);
        }

        public void DisplayChoices()
        {
            Console.WriteLine();
            Console.WriteLine("Choose an opponent or E to exit:");

            int i = 1;
            foreach (ICreature enemy in enemyList)
            {
                Console.WriteLine(" {0}. {1}", i, enemy.Name);
                i++;
            }
        }

        public void BattleArena(Player player, ICreature enemy)
        {
            GameController gameController = new GameController();

            Console.Clear();
            DisplayStats(player);
            Console.WriteLine(" VS");
            DisplayStats(enemy);
            Console.WriteLine();
            Console.Write("Press enter to start the battle..");
            Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("{0} did {1} damage to {2}", player.Name, player.Attack, enemy.Name);
            Console.WriteLine("{0} counterattacked for {1} damage!", enemy.Name, enemy.Attack);
            Console.WriteLine();

            BattleOutcome outcome = gameController.CheckForWinner(player, enemy);

            if (outcome == BattleOutcome.Win)
                Console.Write("{0} has beaten {1}!", player.Name, enemy.Name);
            else if (outcome == BattleOutcome.Draw)
                Console.Write("{0} and {1} both died in the tragic battle.", player.Name, enemy.Name);
            else
                Console.Write("{0} was defeated by {1}!", player.Name, enemy.Name);

            Console.ReadLine();
        }

        public void DisplayStats(ICreature creature)
        {
            Console.WriteLine("Name: {0}", creature.Name);
            Console.WriteLine("HP: {0}", creature.Hp);
            Console.WriteLine("Attack: {0}", creature.Attack);
        }
    }
}
