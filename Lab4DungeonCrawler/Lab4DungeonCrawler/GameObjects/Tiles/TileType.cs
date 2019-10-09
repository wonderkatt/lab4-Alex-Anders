namespace Lab4DungeonCrawler
{
    public abstract class TileType : GameObject
    {
        public TileType(Point point, bool explored)
        {
            Position = point;
            IsExplored = explored;
            Color = System.ConsoleColor.White;
        }
    }
}