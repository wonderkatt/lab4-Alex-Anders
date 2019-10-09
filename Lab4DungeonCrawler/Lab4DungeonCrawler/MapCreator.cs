﻿using System;
using System.Linq;
using System.Collections.Generic;

namespace Lab4DungeonCrawler
{
    public class MapCreator
    {
        private readonly List<GameObject> gameObjects = new List<GameObject>();
        readonly List<Door> Doors;
        readonly List<Key> Keys;

        public MapCreator()
        {
            Doors = new List<Door>
            {
                new RedDoor(new Point(10, 8)),
                new YellowDoor(new Point(9, 20)),
                new YellowDoor(new Point(15, 27)),
                new CyanDoor(new Point(13, 31)),
                new MagentaDoor(new Point(5, 31))
            };

            Keys = new List<Key>
            {
            new RedKey(new Point(5, 2)),
            new YellowKey(new Point(2, 14)),
            new CyanKey(new Point(14, 10)),
            new MagentaKey(new Point(10, 44))
            };
        }

        private readonly char[,] map = new char[,]
        {
            { '#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#' },
            { '#',' ',' ',' ',' ',' ',' ',' ','#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#' },
            { '#',' ',' ',' ',' ',' ',' ',' ','#',' ',' ',' ',' ','#','k','#',' ',' ',' ',' ',' ',' ','#',' ',' ','#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#' },
            { '#','#','#','#','#',' ',' ',' ','#',' ',' ',' ',' ','#','#','#',' ',' ',' ',' ',' ',' ','#','E','#','#','#','#','#','#','#','#','#','#','#','#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#' },
            { '#',' ',' ',' ',' ',' ',' ',' ','#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#','#','#',' ',' ',' ',' ',' ',' ','#',' ',' ',' ','#',' ',' ',' ','#','#','M','#','#','#',' ',' ',' ',' ','#' },
            { '#',' ','k',' ',' ',' ',' ',' ','#',' ',' ','#','#','#','#','#','#','#','#',' ','M',' ','#',' ',' ',' ',' ',' ','M',' ',' ','D',' ',' ',' ','#',' ',' ',' ','#',' ',' ',' ',' ',' ',' ',' ',' ',' ','#' },
            { '#',' ',' ',' ',' ',' ',' ',' ','#',' ',' ','#',' ',' ',' ',' ',' ',' ','#',' ',' ',' ','#',' ',' ',' ',' ',' ',' ',' ',' ','#',' ',' ',' ','#',' ',' ',' ','#',' ',' ',' ',' ',' ',' ',' ',' ',' ','#' },
            { '#',' ',' ',' ',' ',' ',' ',' ','#',' ',' ','#',' ',' ',' ',' ',' ',' ','#',' ',' ',' ','#',' ',' ',' ',' ','#','#','#','#','#',' ',' ',' ','#','#','#','#','#',' ',' ',' ',' ',' ',' ',' ',' ',' ','#' },
            { '#',' ',' ',' ','#','#','#','#','#',' ',' ','#',' ',' ',' ',' ',' ',' ','#',' ',' ',' ','#',' ',' ',' ',' ',' ',' ',' ',' ','#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#','#','#','#','#','#','#' },
            { '#',' ',' ',' ','#',' ',' ',' ','#',' ',' ','#',' ',' ',' ',' ',' ',' ','#','#','D','#','#',' ',' ',' ',' ',' ',' ',' ',' ','#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#',' ',' ',' ',' ',' ','#' },
            { '#',' ',' ',' ','#',' ',' ',' ','D',' ',' ','#',' ',' ',' ',' ',' ',' ','#',' ',' ',' ','#',' ',' ',' ',' ',' ',' ',' ',' ','#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#','k',' ',' ',' ',' ','#' },
            { '#',' ',' ',' ','#',' ',' ',' ','#',' ',' ','#',' ',' ',' ',' ',' ',' ','#',' ',' ',' ','#',' ',' ',' ',' ',' ',' ',' ',' ','#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#',' ',' ',' ',' ',' ','#' },
            { '#',' ',' ',' ','#',' ',' ',' ','#','#','#','#','#','#','#','#','#','#','#',' ',' ',' ','#','#','#','#','#','#',' ',' ',' ','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#',' ',' ',' ','#' },
            { '#',' ',' ',' ','M',' ',' ',' ','#',' ',' ',' ',' ',' ',' ',' ','#',' ',' ',' ',' ',' ','#',' ',' ',' ',' ','#',' ',' ',' ','D',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#' },
            { '#',' ',' ',' ',' ',' ',' ',' ','#',' ','k',' ','#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#',' ',' ',' ','#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#' },
            { '#',' ',' ',' ',' ',' ',' ',' ','#',' ',' ',' ','#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','M',' ',' ','D',' ',' ',' ','#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#' },
            { '#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#' }
        };
        public List<GameObject> CreateMap()
        {
            Point point;
            for (int x = 0; x < map.GetLength(0); x++)
            {
                for (int y = 0; y < map.GetLength(1); y++)
                {
                    if (y == 0 || x == 0 || x == map.GetLength(0) - 1 || y == map.GetLength(1) - 1)
                    {
                        point = new Point(x, y);
                        gameObjects.Add(new WallTile(point, true));
                    }
                    else if (map[x, y] == '#')
                    {
                        point = new Point(x, y);
                        gameObjects.Add(new WallTile(point, false));
                    }
                    else if (x > 6 && x < 11 && y > 12 && y < 17)
                    {
                        point = new Point(x, y);
                        gameObjects.Add(new TagTile(point, true));
                    }
                    else if (map[x, y] == 'E')
                    {
                        point = new Point(x, y);
                        gameObjects.Add(new ExitTile(point, false));
                    }
                    else if (map[x, y] == 'M')
                    {
                        point = new Point(x, y);
                        gameObjects.Add(new Monster(point, false));
                        gameObjects.Add(new FloorTile(point, false));
                    }
                    else if (map[x, y] == ' ')
                    {
                        point = new Point(x, y);
                        gameObjects.Add(new FloorTile(point, false));
                    } 
                }
            }
            gameObjects.AddRange(Keys);
            gameObjects.AddRange(Doors);
            
            return gameObjects;
        }
    }
}