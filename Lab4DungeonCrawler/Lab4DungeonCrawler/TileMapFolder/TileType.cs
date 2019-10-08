namespace Lab4DungeonCrawler
{
    public abstract class TileType : GameObject
    {
        public bool IsExplored { get; set; } //Tile
        public Point Position { get; set; } //GameObject
        public char Symbol { get; set; } //GameObject
        public Key Key { get; set; } //Typer som ärver ifrån GameObject eller Tile
        public Door Door { get; set; }
        public Monster Monster { get; set; }

        public TileType(Point point, bool explored)
        {
            Position = point;
            IsExplored = explored;
        }
    }
}