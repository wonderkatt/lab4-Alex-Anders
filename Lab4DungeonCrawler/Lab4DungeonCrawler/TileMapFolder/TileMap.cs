﻿using System;

namespace Lab4DungeonCrawler
{
    public class TileMap
    {
        private const int height = 15;
        private const int width = 50;
        private readonly Player player;
        private static TileType[,] map = new TileType[height, width];

        public TileMap()
        {
            this.player = player;
            

        }

        public static TileType[,] GetTileMap()
        {
            return map;
        }

        public void InitiateMap()
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