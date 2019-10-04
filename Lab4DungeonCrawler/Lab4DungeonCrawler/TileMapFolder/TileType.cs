namespace Lab4DungeonCrawler
{
    public abstract class TileType
    {
        public bool IsExplored { get; set; }
        public Point Position { get; set; }
        public char Symbol { get; set; }

        public TileType(Point point, bool explored)
        {
            Position = point;
            IsExplored = explored;
        }
    }
}