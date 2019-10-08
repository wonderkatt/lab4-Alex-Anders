namespace Lab4DungeonCrawler
{
    internal class MagentaKey : Key
    {
        public MagentaKey()
        {
            NumberOfUses = 1;
            Color = System.ConsoleColor.Magenta;
            Position = new Point(10, 44);
        }
    }
}