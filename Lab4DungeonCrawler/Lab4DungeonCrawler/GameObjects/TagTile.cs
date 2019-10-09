namespace Lab4DungeonCrawler
{
    internal class TagTile : TileType
    {
        private char[,] tagSymbols = new char[,]
        {
        { 'A', 'L', 'E', 'X' },
        { 'N', ' ', ' ', ' ' },
        { 'O', ' ', ' ', ' ' },
        { 'R', ' ', ' ', ' ' }
        };

        public TagTile(Point point, bool explored) : base(point, explored)
        {
            Symbol = tagSymbols[point.row - 7, point.column - 13];
            Color = System.ConsoleColor.Gray;
        }
    }
}