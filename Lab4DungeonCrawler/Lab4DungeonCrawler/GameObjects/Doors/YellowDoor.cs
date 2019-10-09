namespace Lab4DungeonCrawler
{
    internal class YellowDoor : Door
    {
        public YellowDoor(Point point)
        {
            Position = point;
            Color = System.ConsoleColor.Yellow;
            IsExplored = false;
        }
    }
}