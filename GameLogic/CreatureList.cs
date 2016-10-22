namespace GameLogic
{
    public class CreatureList
    {
        ICreature[] enemyList;

        public CreatureList()
        {
            ResetCreatures();
        }

        public void ResetCreatures()
        {
            enemyList = new ICreature[]
            {
                new Enemy("Leaf in the wind", 10, 0, 1),
                new Enemy("Street dog", 2, 3, 1),
                new Enemy("Local drunk", 6, 4, 2),
                new Enemy("Weak, sick, handicapped and wounded Goblin", 10, 12, 3)
            };
        }

        public ICreature[] EnemyList
        {
            get
            {
                ResetCreatures();
                return enemyList;
            }
        }
    }
}
