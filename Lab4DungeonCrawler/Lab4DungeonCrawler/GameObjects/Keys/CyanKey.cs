namespace Lab4DungeonCrawler
{
    public class CyanKey : Key
    {
        public CyanKey(Point point) : base(point)
        {
            Name = "Cyan key";
            NumberOfUses = 1;
            Color = System.ConsoleColor.Cyan;
        }
    }
}