﻿using System;
using System.Collections.Generic;
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
            Console.WriteLine("{0} HP: {1}/{2}", player.Name, player.Hp, player.Hp);
            Console.WriteLine("Choose an option: ");
            Console.WriteLine(" 1. Arena");
            Console.WriteLine(" 2. Stats");
        }

        public static void DisplayInputError()
        {
            Console.WriteLine("You've got fat fingers! Now try again..");
            Console.ReadLine();
        }
        
    }
}
