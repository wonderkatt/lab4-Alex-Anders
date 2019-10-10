namespace Lab4DungeonCrawler
{
    public abstract class Tile : GameObject
    {
        public Tile(Point point, bool explored)
        {
            Position = point;
            IsExplored = explored;
            Color = System.ConsoleColor.White;
        }
    }
}