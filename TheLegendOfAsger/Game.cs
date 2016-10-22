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

                    case "3":
                        Days.PassDay();
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
            DisplayDay();
            Console.WriteLine("{0} HP: {1}/{2}", player.Name, player.Hp, player.MaxHp);
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

        public static void DisplayDay()
        {
            switch (Days.CurrentDay)
            {
                case WeekDays.Monday:
                    Console.WriteLine("Monday");
                    break;

                case WeekDays.Tuesday:
                    Console.WriteLine("Tuesday");
                    break;

                case WeekDays.Wednesday:
                    Console.WriteLine("Wednesday");
                    break;

                case WeekDays.Thursday:
                    Console.WriteLine("Thursday");
                    break;

                case WeekDays.Friday:
                    Console.WriteLine("Friday");
                    break;

                case WeekDays.Saturday:
                    Console.WriteLine("Saturday");
                    break;

                case WeekDays.Sunday:
                    Console.WriteLine("Sunday");
                    break;
            }
        }
        
    }
}
