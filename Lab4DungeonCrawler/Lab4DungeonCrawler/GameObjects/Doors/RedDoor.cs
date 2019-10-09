namespace Lab4DungeonCrawler
{
    internal class RedDoor : Door
    {
        public RedDoor(Point point)
        {
            Position = point;
            Color = System.ConsoleColor.Red;
            IsExplored = false;
        }
    }
}