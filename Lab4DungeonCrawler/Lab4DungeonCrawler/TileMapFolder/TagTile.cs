namespace Lab4DungeonCrawler
{
    internal class TagTile : TileType
    {
        public TagTile(Point point, bool explored) : base(point, explored)
        {
            char[,] tagSymbols = new char[,]
            {
            { 'A', ' ', 'A' },
            { 'L', ' ', 'N' },
            { 'E', ' ', 'O' },
            { 'X', ' ', 'R' }
            };

            IsExplored = explored;
            Position = point;
            Symbol = tagSymbols[point.row - 7, point.column - 13];
        }
    }
}