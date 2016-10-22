using System;
using System.Collections.Generic;
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
                        break;
                    case "3":
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
            Console.WriteLine("Choose an option: ");
            Console.WriteLine(" 1. Arena");
        }

        public static void DisplayInputError()
        {
            Console.WriteLine("You've got fat fingers! Now try again..");
            Console.ReadLine();
        }
        
    }
}
