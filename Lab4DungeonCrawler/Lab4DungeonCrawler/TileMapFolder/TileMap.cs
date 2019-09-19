using System;

namespace Lab4DungeonCrawler
{
    public class TileMap
    {
        private const int height = 15;
        private const int width = 15;
        private readonly Player player;
        public PlayerController playerController;
        public TileType[,] map = new TileType[width,height];
       

        public TileMap(Player player)
        {
            this.player = player;
        }

        public void InitiateMap()
        {
            for (int row = 0; row < map.GetLength(0); row++)
            {
                for (int column = 0; column < map.GetLength(1); column++)
                {
                    if ((row == 0 || column == 0 || row == map.GetLength(0) - 1 || column == map.GetLength(1) - 1))
                    {
                        map[row, column] = new WallTile();
                    }
                    else
                    {
                        map[row, column] = new FloorTile();
                    }

                }
            }
            map[player.currentPosition.row, player.currentPosition.column] = new PlayerTile();

        }

        public void PrintOutMap()
        {
            Console.Clear();
            for (int row = 0; row < map.GetLength(0); row++)
            {
                for (int column = 0; column < map.GetLength(1); column++)
                {
                    Console.Write(map[row, column].TileGraphic);
                }
                Console.WriteLine();
            }
        }
    }
}