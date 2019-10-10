namespace Lab4DungeonCrawler
{
    public class YellowKey : Key
    {
        public YellowKey(Point point) : base(point)
        {
            Name = "Yellow key";
            NumberOfUses = 2;
            Color = System.ConsoleColor.Yellow;
        }
    }
}