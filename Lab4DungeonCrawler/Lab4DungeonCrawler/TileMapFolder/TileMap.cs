using System;

namespace Lab4DungeonCrawler
{
    public class TileMap
    {
        private const int x = 25;
        private const int y = 25;
        private static TileType[,] map = new TileType[x, y];

        public TileMap()
        {
            InitiateMap();
        }

        

        public static TileType[,] GetTileMap()
        {
            return map;
        }

        private void InitiateMap()
        {
            for (int column = 0; column < map.GetLength(0); column++)
            {
                for (int row = 0; row < map.GetLength(1); row++)
                {
                    if ((column == 0 || row == 0 || column == map.GetLength(0) - 1 || row == map.GetLength(1) - 1))
                    {
                        map[column, row] = new WallTile();
                    }
                    else
                    {
                        map[column, row] = new FloorTile();
                    }

                }
            }
            

        }

        

        
    }
}