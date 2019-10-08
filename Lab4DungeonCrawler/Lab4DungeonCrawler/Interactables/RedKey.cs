namespace Lab4DungeonCrawler
{
    internal class RedKey : Key
    {
        public RedKey()
        {
            NumberOfUses = 1;
            Color = System.ConsoleColor.Red;
            Position = new Point(5, 2);
            
        }
    }
}