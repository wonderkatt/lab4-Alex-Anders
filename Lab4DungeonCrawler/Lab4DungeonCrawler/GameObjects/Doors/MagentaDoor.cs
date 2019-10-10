namespace Lab4DungeonCrawler
{
    public class MagentaDoor : Door
    {
        public MagentaDoor(Point point) : base(point)
        {
            Color = System.ConsoleColor.Magenta;
        }
    }
}