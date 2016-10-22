using System;
using GameLogic;

namespace TheLegendOfAsger
{
    class Arena
    {
        ICreature[] enemyList = new ICreature[]
        {
            new Enemy("Leaf in the wind", 10, 0, 1),
            new Enemy("Street dog", 2, 3, 1),
            new Enemy("Local drunk", 6, 4, 2),
            new Enemy("Weak, sick, handicapped and wounded Goblin", 10, 12, 3)
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

        private void DisplayChoices()
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

        private void BattleArena(Player player, ICreature enemy)
        {
            GameController gameController = new GameController();
            BattleOutcome outcome = BattleOutcome.None;

            do
            {
                Console.Clear();
                DisplayStats(player);
                Console.WriteLine(" VS");
                DisplayStats(enemy);
                Console.WriteLine();
                Console.Write("Press enter to start the round..");
                Console.ReadLine();

                Console.WriteLine();
                Console.WriteLine("{0} did {1} damage to {2}", player.Name, player.Attack, enemy.Name);
                Console.WriteLine("{0} counterattacked for {1} damage!", enemy.Name, enemy.Attack);
                Console.ReadLine();

                outcome = gameController.CheckForWinner(player, enemy);
            }
            while (outcome == BattleOutcome.None);

            switch (outcome) {
                case BattleOutcome.Win:
                    Console.WriteLine("{0} has beaten {1}!", player.Name, enemy.Name);
                    Console.Write("{0} has gained {1} skill point(s)!", player.Name, enemy.SkillPoint);
                    break;

                case BattleOutcome.Draw:
                    Console.Write("{0} and {1} both passed out in the tragic battle.", player.Name, enemy.Name);
                    break;

                case BattleOutcome.Lose:
                    Console.Write("{0} was defeated by {1}!", player.Name, enemy.Name);
                    break;
            }

            Console.ReadLine();
        }

        private void DisplayStats(ICreature creature)
        {
            Console.WriteLine("Name: {0}", creature.Name);
            Console.WriteLine("HP: {0}", creature.Hp);
            Console.WriteLine("Attack: {0}", creature.Attack);
        }
    }
}
