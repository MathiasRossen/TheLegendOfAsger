using System;
using GameLogic;

namespace TheLegendOfAsger
{
    class Game
    {
        Player player;

        public void Run()
        {
            bool running = true;
            string input;
            player = new Player();

            DisplayTitleScreen();

            do
            {
                Console.Clear();
                DisplayChoices();

                input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Arena arena = new Arena();
                        arena.ArenaLoop(player);
                        break;

                    case "2":
                        Stats stats = new Stats();
                        stats.StatLoop(player);
                        break;

                    case "3":
                        Rest(player);
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

        public void DisplayChoices()
        {
            Console.WriteLine("Day {3}: {4}. {0} HP: {1}/{2}", player.Name, player.Hp, player.MaxHp, Days.TotalDays, Days.CurrentDay.ToString());
            Console.WriteLine();
            Console.WriteLine("Choose an option: ");
            Console.WriteLine(" 1. Arena");
            Console.WriteLine(" 2. Stats");
            Console.WriteLine(" 3. Pass day");
        }

        public static void DisplayInputError()
        {
            Console.WriteLine("You've got fat fingers! Now try again..");
            Console.ReadLine();
        }

        private void Rest(Player player)
        {
            if (Days.CurrentDay == WeekDays.Sunday)
                player.Hp = player.MaxHp;

            Days.PassDay();
        }
    }
}
