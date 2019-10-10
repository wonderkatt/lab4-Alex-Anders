namespace Lab4DungeonCrawler
{
    public class CyanDoor : Door
    {
        public CyanDoor(Point point) : base(point)
        {
            Color = System.ConsoleColor.Cyan;
        }
    }
}