namespace Lab4DungeonCrawler
{
    public class YellowDoor : Door
    {
        public YellowDoor(Point point) : base(point)
        {
            Color = System.ConsoleColor.Yellow;
        }
    }
}