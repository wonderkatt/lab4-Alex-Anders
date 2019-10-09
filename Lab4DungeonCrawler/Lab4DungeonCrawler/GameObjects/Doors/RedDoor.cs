namespace Lab4DungeonCrawler
{
    internal class RedDoor : Door
    {
        public RedDoor(Point point) : base(point)
        {
            Color = System.ConsoleColor.Red;
        }
    }
}