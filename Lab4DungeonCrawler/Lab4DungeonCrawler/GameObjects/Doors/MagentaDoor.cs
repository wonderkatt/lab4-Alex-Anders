namespace Lab4DungeonCrawler
{
    internal class MagentaDoor : Door
    {
        public MagentaDoor(Point point)
        {
            Position = point;
            Color = System.ConsoleColor.Magenta;
            IsExplored = false;
        }
    }
}