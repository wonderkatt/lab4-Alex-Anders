namespace Lab4DungeonCrawler
{
    public abstract class TileType
    {
        public bool IsExplored { get; set; }
        public Point Position { get; set; } //get??

        public TileType(Point point)
        {
            Position = point;
        }
    }
}