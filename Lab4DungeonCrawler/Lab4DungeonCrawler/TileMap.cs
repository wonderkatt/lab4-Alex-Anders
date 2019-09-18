using System;

namespace Lab4DungeonCrawler
{
    public class TileMap
    {
        private const int height = 50;
        private const int width = 10;
        static string[,] map = new string[width,height];

        public TileMap()
        {
            for (int row = 0; row < map.GetLength(0); row++)
            {
                for (int column = 0; column < map.GetLength(1); column++)
                {
                    if ((row == 0 || column == 0 || row == map.GetLength(0) - 1 || column == map.GetLength(1) - 1))
                    {
                        map[row, column] = "#";
                    }
                    else
                    {
                        map[row, column] = "-";
                    }
                    
                }
            }
        }

        public void PrintOutMap()
        {
            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    Console.Write(map[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}