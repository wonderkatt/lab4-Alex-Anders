namespace Lab4DungeonCrawler
{
    internal class YellowKey : Key
    {
        public YellowKey()
        {
            NumberOfUses = 2;
            Color = System.ConsoleColor.Yellow;
            Position = new Point(2, 14);
        }
    }
}