namespace Lab4DungeonCrawler
{
    internal class CyanDoor : Door
    {
        public CyanDoor(Point point) : base(point)
        {
            Color = System.ConsoleColor.Cyan;
        }
    }
}