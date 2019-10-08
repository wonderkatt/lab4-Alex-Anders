namespace Lab4DungeonCrawler
{
    internal class CyanKey : Key
    {
        public CyanKey()
        {
            NumberOfUses = 1;
            Color = System.ConsoleColor.Cyan;
            Position = new Point(14, 10);
        }
    }
}