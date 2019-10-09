namespace Lab4DungeonCrawler
{
    internal class RedDoor : Door
    {
        public RedDoor()
        {
            Position = new Point(10, 8);
            Color = System.ConsoleColor.Red;
            IsExplored = false;
        }
    }
}