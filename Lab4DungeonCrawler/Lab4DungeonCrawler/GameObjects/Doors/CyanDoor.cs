namespace Lab4DungeonCrawler
{
    internal class CyanDoor : Door
    {
        public CyanDoor()
        {
            Position = new Point(13, 31);
            Color = System.ConsoleColor.Cyan;
            IsExplored = false;
        }
    }
}