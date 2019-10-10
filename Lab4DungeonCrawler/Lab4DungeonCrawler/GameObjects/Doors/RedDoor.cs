namespace Lab4DungeonCrawler
{
    public class RedDoor : Door
    {
        public RedDoor(Point point) : base(point)
        {
            Color = System.ConsoleColor.Red;
        }
    }
}