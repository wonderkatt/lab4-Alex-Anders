namespace Lab4DungeonCrawler
{
    internal class YellowDoor : Door
    {
        public YellowDoor(Point point) : base(point)
        {
            Color = System.ConsoleColor.Yellow;
        }
    }
}