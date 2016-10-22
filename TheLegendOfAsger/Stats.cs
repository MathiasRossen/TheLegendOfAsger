using System;
using GameLogic;

namespace TheLegendOfAsger
{
    class Stats
    {
        public void StatLoop(Player player)
        {
            bool running = true;
            string input;

            do
            {
                Console.Clear();
                DisplayStats(player);
                DisplayChoices(player);
                input = Console.ReadLine();

                switch (input.ToLower())
                {
                    case "1":
                        if (player.SkillPoint > 0)
                            player.IncreaseSkillHpByOne();
                        else running = false;
                        break;
                    case "2":
                        if (player.SkillPoint > 0)
                            player.IncreaseSkillAttackByOne();
                        else running = false;
                        break;
                    default:
                        running = false;
                        break;
                }
            }
            while (running);
        }

        private void DisplayStats(Player player)
        {
            Console.WriteLine("Name: {0}", player.Name);
            Console.WriteLine("HP: {0}", player.Hp);
            Console.WriteLine("Attack: {0}", player.Attack);
            Console.WriteLine();
            Console.WriteLine("Skill points: {0}", player.SkillPoint);
        }

        private void DisplayChoices(Player player)
        {
            if (player.SkillPoint > 0)
            {
                Console.WriteLine();
                Console.WriteLine("Choose and option or E to exit");
                Console.WriteLine(" 1. Increase HP by 1");
                Console.WriteLine(" 2. Increase Attack by 1");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Press any key to exit..");
            }
        }
    }
}
