namespace Lab4DungeonCrawler
{
    internal class MagentaKey : Key
    {
        public MagentaKey(Point point) : base(point)
        {
            Name = "Magenta key";
            NumberOfUses = 1;
            Color = System.ConsoleColor.Magenta;
        }
    }
}