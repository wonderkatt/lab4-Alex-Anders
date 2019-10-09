namespace Lab4DungeonCrawler
{
    internal class YellowKey : Key
    {
        public YellowKey(Point point)
        {
            Name = "Yellow key";
            NumberOfUses = 2;
            Color = System.ConsoleColor.Yellow;
            Position = point;
        }
    }
}