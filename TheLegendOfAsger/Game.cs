using System;
using GameLogic;

namespace TheLegendOfAsger
{
    class Game
    {
        public void Run()
        {
            bool running = true;
            string input;
            Player player = new Player();
            ICreature enemy;

            DisplayTitleScreen();

            do
            {
                Console.Clear();
                DisplayStats(player);
                DisplayChoices();

                input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        enemy = new Enemy("Street dog", 5, 5);
                        BattleArena(player, enemy);
                        break;
                    case "2":
                        enemy = new Enemy("Local drunk", 6, 6);
                        BattleArena(player, enemy);
                        break;
                    default:
                        DisplayInputError();
                        break;
                }
            }
            while (running);
        }

        public void DisplayTitleScreen()
        {
            Console.Write("Welcome to...");
            Console.ReadLine();

            Console.WriteLine("########################################################");
            Console.WriteLine("# ▄▄▄ ▄  ▄ ▄▄▄   ▄   ▄▄▄ ▄▄▄▄ ▄▄▄ ▄  ▄ ▄▄▄     ▄▄  ▄▄▄ #");
            Console.WriteLine("#  █  █▄▄█ █▄    █   █▄  █ ▄▄ █▄  █▄ █ █  █   █  █ █▄  #");
            Console.WriteLine("#  █  █  █ █▄▄   █▄▄ █▄▄ █▄▄█ █▄▄ █ ▀█ █▄▄▀   ▀▄▄▀ █   #");
            Console.WriteLine("#                                                      #");
            Console.WriteLine("#                                                      #");
            Console.WriteLine("#      ██       ██████    ██████    ██████   █████     #");
            Console.WriteLine("#     ████     ██        ██         ██       ██   ██   #");
            Console.WriteLine("#    ██  ██      ███     ██  ███    ████     ██   ██   #");
            Console.WriteLine("#   ████████        ██   ██    ██   ██       █████     #");
            Console.WriteLine("#   ██    ██   ██████     ██████    ██████   ██   ██   #");
            Console.WriteLine("#                                                      #");
            Console.WriteLine("########################################################");

            Console.ReadLine();
        }

        public void DisplayStats(ICreature creature)
        {
            Console.WriteLine("Name: {0}", creature.Name);
            Console.WriteLine("HP: {0}", creature.Hp);
            Console.WriteLine("Attack: {0}", creature.Attack);
        }

        public void DisplayChoices()
        {
            Console.WriteLine();
            Console.WriteLine("Choose an opponent:");
            Console.WriteLine(" 1. Street dog");
            Console.WriteLine(" 2. Local drunk");
        }

        public void DisplayInputError()
        {
            Console.WriteLine("You've got fat fingers! Now try again..");
            Console.ReadLine();
        }

        public void BattleArena(ICreature creatureOne, ICreature creatureTwo)
        {
            GameController gameController = new GameController();

            Console.Clear();
            DisplayStats(creatureOne);
            Console.WriteLine(" VS");
            DisplayStats(creatureTwo);
            Console.WriteLine();
            Console.Write("Press enter to start the battle..");
            Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("{0} did {1} damage to {2}", creatureOne.Name, creatureOne.Attack, creatureTwo.Name);
            Console.WriteLine("{0} counterattacked for {1} damage!", creatureTwo.Name, creatureTwo.Attack);
            Console.WriteLine();

            BattleOutcome outcome = gameController.CheckForWinner(creatureOne, creatureTwo);

            if (outcome == BattleOutcome.Win)
                Console.Write("{0} has beaten {1}!", creatureOne.Name, creatureTwo.Name);
            else if (outcome == BattleOutcome.Draw)
                Console.Write("{0} and {1} both died in the tragic battle.", creatureOne.Name, creatureTwo.Name);
            else
                Console.Write("{0} was defeated by {1}!", creatureOne.Name, creatureTwo.Name);

            Console.ReadLine();
        }
    }
}
