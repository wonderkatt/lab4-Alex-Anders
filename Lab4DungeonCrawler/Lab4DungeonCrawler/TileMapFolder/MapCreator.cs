﻿using System;
using System.Collections.Generic;

namespace Lab4DungeonCrawler
{
    public class MapCreator
    {

        private readonly List<TileType> gameObjects = new List<TileType>();
        public MapCreator()
        {
        }

        private readonly char[,] map = new char[,]
        {
            { '#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#' },
            { '#','-','-','-','-','-','-','-','#','-','-','-','-','-','-','-','-','-','-','-','-','#','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','#' },
            { '#','-','-','-','-','-','-','-','#','-','-','-','-','#','k','#','-','-','-','-','-','#','-','-','-','#','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','#' },
            { '#','#','#','#','#','-','-','-','#','-','-','-','-','#','#','#','-','-','-','-','-','#','U','#','#','#','#','#','#','#','#','#','#','#','#','#','-','-','-','-','-','-','-','-','-','-','-','-','-','#' },
            { '#','-','-','-','-','-','-','-','#','-','-','-','-','-','-','-','-','-','-','-','-','#','#','#','-','-','-','-','-','-','-','#','-','-','-','#','-','-','#','#','#','M','#','#','#','-','-','-','-','#' },
            { '#','-','k','-','-','-','-','-','#','-','-','#','#','#','#','#','#','#','-','-','-','-','#','-','-','-','-','-','M','-','-','D','-','-','-','#','-','-','#','-','-','-','-','-','-','-','-','-','-','#' },
            { '#','-','-','-','-','-','-','-','#','-','-','#','-','-','-','-','-','#','-','M','-','-','#','-','-','-','-','-','-','-','-','#','-','-','-','#','#','#','#','-','-','-','-','-','-','-','-','-','-','#' },
            { '#','-','-','-','-','-','-','-','#','-','-','#','-','A','-','A','-','#','-','-','-','-','#','-','-','-','#','#','#','#','#','#','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','#' },
            { '#','-','-','-','#','#','#','#','#','-','-','#','-','L','-','N','-','#','-','-','#','#','#','-','-','-','-','-','-','-','-','#','-','-','-','-','-','-','-','-','-','-','#','#','#','#','#','#','#','#' },
            { '#','-','-','-','#','-','-','-','#','-','-','#','-','E','-','O','-','#','#','D','#','-','-','-','-','-','-','-','-','-','-','#','-','-','-','-','-','-','-','-','-','-','#','-','-','-','-','-','-','#' },
            { '#','-','-','-','#','-','-','-','D','-','-','#','-','X','-','R','-','#','-','-','#','-','-','-','-','-','-','-','-','-','-','#','-','-','-','-','-','-','-','-','-','-','#','k','-','-','-','-','-','#' },
            { '#','-','-','-','#','-','-','-','#','-','-','#','-','-','-','-','-','#','-','-','#','-','-','-','-','-','-','-','-','-','-','#','-','-','-','-','-','-','-','-','-','-','#','-','-','-','-','-','-','#' },
            { '#','-','-','-','#','-','-','-','#','#','#','#','#','#','#','#','#','#','-','-','#','#','#','#','#','#','#','#','-','-','-','#','#','#','#','#','#','#','#','#','#','#','#','#','#','-','-','-','-','#' },
            { '#','-','-','-','M','-','-','-','#','-','-','-','-','-','-','-','#','-','-','-','#','-','-','-','-','-','-','#','-','-','-','D','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','#' },
            { '#','-','-','-','-','-','-','-','#','-','k','-','#','-','-','-','-','-','-','-','-','-','-','-','-','-','-','#','-','-','-','#','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','#' },
            { '#','-','-','-','-','-','-','-','#','-','-','-','#','-','-','-','-','-','-','-','-','-','M','-','-','-','-','D','-','-','-','#','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','#' },
            { '#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#' }
        };
        public List<TileType> CreateMap()
        {
            Point point;
            for (int x = 0; x < map.GetLength(0); x++)
            {
                for (int y = 0; y < map.GetLength(1); y++)
                {
                    if (y == 0 || x == 0 || x == map.GetLength(0) - 1 ||  y == map.GetLength(1) - 1)
                    {
                        point = new Point(x, y);
                        gameObjects.Add(new WallTile(point, true));
                    }
                    else if (map[x,y] == '#')
                    {
                        point = new Point(x, y);
                        gameObjects.Add(new WallTile(point, false));
                    }
                    else if (x > 6 && x < 11 && y > 12 && y < 16)
                    {
                        point = new Point(x, y);
                        gameObjects.Add(new TagTile(point, true));
                    }
                    else if (map[x, y] == 'U')
                    {
                        point = new Point(x, y);
                        gameObjects.Add(new ExitTile(point, false));
                    }
                    else
                    {
                        point = new Point(x, y);
                        gameObjects.Add(new FloorTile(point,false));
                    }
                }
            }
            return gameObjects;
        }
    }
}