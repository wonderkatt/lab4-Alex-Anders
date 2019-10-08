namespace Lab4DungeonCrawler
{
    internal class MagentaDoor : Door
    {
        public MagentaDoor()
        {
            Position = new Point(5, 31);
            Color = System.ConsoleColor.Magenta;
            IsExplored = false;
        }
    }
}