namespace Lab4DungeonCrawler
{
    public abstract class TileType
    {
        string tileGraphic;

       

        public bool IsExplored { get; set; }

        public string TileGraphic { get { return tileGraphic; } set { tileGraphic = value; } }
    }
}