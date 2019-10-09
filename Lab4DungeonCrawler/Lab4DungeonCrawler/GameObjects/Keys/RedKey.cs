namespace Lab4DungeonCrawler
{
    internal class RedKey : Key
    {
        public RedKey(Point point)
        {
            Name = "Red key";
            NumberOfUses = 1;
            Color = System.ConsoleColor.Red;
            Position = point;
            
        }
    }
}