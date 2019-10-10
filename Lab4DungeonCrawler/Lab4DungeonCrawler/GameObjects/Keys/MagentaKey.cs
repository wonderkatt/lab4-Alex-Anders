namespace Lab4DungeonCrawler
{
    public class MagentaKey : Key
    {
        public MagentaKey(Point point) : base(point)
        {
            Name = "Magenta key";
            NumberOfUses = 1;
            Color = System.ConsoleColor.Magenta;
        }
    }
}