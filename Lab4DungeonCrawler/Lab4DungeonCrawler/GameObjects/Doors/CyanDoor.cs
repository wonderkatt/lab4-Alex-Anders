namespace Lab4DungeonCrawler
{
    internal class CyanDoor : Door
    {
        public CyanDoor(Point point)
        {
            Position = point;
            Color = System.ConsoleColor.Cyan;
            IsExplored = false;
        }
    }
}