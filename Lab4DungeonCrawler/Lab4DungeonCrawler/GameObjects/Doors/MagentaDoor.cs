namespace Lab4DungeonCrawler
{
    internal class MagentaDoor : Door
    {
        public MagentaDoor(Point point) : base(point)
        {
            Color = System.ConsoleColor.Magenta;
        }
    }
}